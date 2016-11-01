//===================================

using System;
using as3;
using Bridge;
using Bridge.Html5;
using flash.xml;
using RockiePlayer;
using Array = as3.Array;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================
using Rectangle = flash.geom.Rectangle;
using Point = flash.geom.Point;
using BitmapFilter = flash.filters.BitmapFilter;
using ColorTransform = flash.geom.ColorTransform;
using Matrix = flash.geom.Matrix;
using ByteArray = flash.utils.ByteArray;
using Object = as3.Object;

namespace flash.display
{
	//[native(instance="BitmapDataObject",methods="auto",cls="BitmapDataClass",gc="exact")]
	public class BitmapData : Object, IBitmapDrawable
	{
		public event Action Changed;
		public event Action CanDraw;

		protected string _url = null;

		private void changed()
		{
			if (Changed != null)
				Changed();
		}

		protected void AS3_ctor(int width = 0, int height = 0, bool transparent = true, uint fillColor = 0xffffffff)
		{
			base.AS3_ctor();
			ctor(width, height, transparent, fillColor);
		}

		public BitmapData(int width = 0, int height = 0, bool transparent = true, uint fillColor = 0xffffffff)
		{
			AS3_ctor(width, height, transparent, fillColor);
		}

		private void ctor(int width, int height, bool transparent, uint fillColor)
		{
			this.width = width;
			this.height = height;
			this.transparent = transparent;
		}

		protected void setPixels(String data, as3.Function onLoadData = null, CasheImages casheImages = null)
		{
			_url = "graphics/" + data + ".png";

			if (casheImages != null && casheImages.checkContainsImage(this))
				return;

			Resources.LoadBitmapData(this, _url, width, height);
		}

		public bool canDraw
		{
			get { return _canDraw; }
			set
			{
				_canDraw = value;
				changed();

				if (_canDraw && CanDraw != null)
					CanDraw();
			}
		}

		private ImageData _imageData;
		internal ImageData imageData
		{
			get
			{
				if (_imageData == null)
				{
					if (internalImage == null)
					{
						_imageData = new ImageData((uint)this.width, (uint)this.height);
						return _imageData;
					}

					var canvasElement = internalImage.FastAs<HTMLCanvasElement>();
					if (canvasElement != null)
					{
						var newCanvas = new HTMLCanvasElement();
						var context = newCanvas.GetContext(CanvasTypes.CanvasContext2DType.CanvasRenderingContext2D);
						newCanvas.Width = canvasElement.Width;
						newCanvas.Height = canvasElement.Height;

						context.DrawImage(internalImage, 0, 0);
						_imageData = context.GetImageData(0, 0, context.Canvas.Width, context.Canvas.Height);
						internalImage = context;
					}
					var imageElement = internalImage.FastAs<HTMLImageElement>();
					if (imageElement != null)
					{
						var newCanvas = new HTMLCanvasElement();
						var context = newCanvas.GetContext(CanvasTypes.CanvasContext2DType.CanvasRenderingContext2D);
						newCanvas.Width = imageElement.Width;
						newCanvas.Height = imageElement.Height;

						context.DrawImage(internalImage, 0, 0);
						_imageData = context.GetImageData(0, 0, context.Canvas.Width, context.Canvas.Height);
						internalImage = context;
					}

					var canvas2DContext = internalImage.FastAs<CanvasRenderingContext2D>();
					if (canvas2DContext != null)
					{
						_imageData = canvas2DContext.GetImageData(0, 0, canvas2DContext.Canvas.Width, canvas2DContext.Canvas.Height);
					}
				}

				return _imageData;
			}
		}

		public virtual BitmapData clone()
		{
			var bitmapData = new BitmapData();
			var canvas = new HTMLCanvasElement();
			canvas.Width = this.width;
			canvas.Height = this.height;
			var context2d = canvas.GetContext(CanvasTypes.CanvasContext2DType.CanvasRenderingContext2D);
			var ctx = new RenderingContext2D(context2d);
			this.drawSelf(context2d, 0, 0, this.width, this.height);
			bitmapData.internalImage = context2d;
			return bitmapData;
		}

		private uint pixelSize { get { return transparent ? 4u : 3u; } }

		public virtual uint getPixel(int x, int y)
		{
			var data = imageData;
			var i = (x + y * (int)data.Width) * (int)pixelSize;
			var a = data.Data;
			return (uint)(a[i + 2] | a[i + 1] << 8 | a[i] << 16);
		}

		public virtual uint getPixel32(int x, int y)
		{
			var data = imageData;
			var i = (x + y * (int)data.Width) * (int)pixelSize;
			var a = data.Data;
			return (uint)(a[i + 2] | (a[i + 1] << 8) | (a[i] << 16) | (a[i + 3] << 24));
		}

		public virtual void setPixel(int x, int y, uint color)
		{
			var data = imageData;
			var i = (x + y * (int)data.Width) * (int)pixelSize;
			var a = data.Data;
			a[i] = (byte)(color >> 16);
			a[i + 1] = (byte)(color >> 8);
			a[i + 2] = (byte)color;
		}

		public virtual void setPixel32(int x, int y, uint color)
		{
			var data = imageData;
			var i = (x + y * (int)data.Width) * (int)pixelSize;
			var a = data.Data;
			a[i] = (byte)(color >> 16);
			a[i + 1] = (byte)(color >> 8);
			a[i + 2] = (byte)color;

			if (transparent && pixelSize == 4u)
				a[i + 3] = (byte)(color >> 24);
		}

		public virtual void applyFilter(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint,
			BitmapFilter filter)
		{
			filter.apply(sourceBitmapData, sourceRect, this, destPoint);
		}

		public virtual void colorTransform(Rectangle rect, ColorTransform colorTransform)
		{
			for (var x = (int)rect.x; x < rect.x + rect.width; x++)
				for (var y = (int)rect.y; y < rect.y + rect.height; y++)
				{
					setPixel32(x, y, colorTransform.transformColor(getPixel32(x, y)));
				}
		}

		extern public virtual Object compare(BitmapData otherBitmapData);

		extern public virtual void copyChannel(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, uint sourceChannel, uint destChannel);

		extern public virtual void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, BitmapData alphaBitmapData = null, Point alphaPoint = null, bool mergeAlpha = false);

		extern public virtual void dispose();

		public virtual void draw(IBitmapDrawable source, Matrix matrix = null, ColorTransform colorTransform = null, string blendMode = null, Rectangle clipRect = null, bool smoothing = false)
		{
			var sourceDisplayObject = source as DisplayObject;

			if (sourceDisplayObject != null)
			{
				if (clipRect != null)
				{
					this.width = (int)clipRect.width;
					this.height = (int)clipRect.height;
				}
				else
				{
					this.width = (int)sourceDisplayObject.width;
					this.height = (int)sourceDisplayObject.height;
				}

				if (matrix != null)
					sourceDisplayObject.transform.matrix = matrix;

				if (colorTransform != null)
					sourceDisplayObject.transform.colorTransform = colorTransform;

				RenderingContext2D ctx;
				CanvasRenderingContext2D result;
				if (_internalImage.FastAs<CanvasRenderingContext2D>() != null)
				{
					ctx = new RenderingContext2D((CanvasRenderingContext2D)_internalImage);
					result = (CanvasRenderingContext2D)_internalImage;
				}
				else
				{
					var canvas = new HTMLCanvasElement();
					canvas.Width = this.width;
					canvas.Height = this.height;
					var context2d = canvas.GetContext(CanvasTypes.CanvasContext2DType.CanvasRenderingContext2D);
					ctx = new RenderingContext2D(context2d);
					this.drawSelf(context2d, 0, 0, this.width, this.height);
					result = context2d;
				}

				ctx.ctx.Save();
				if (clipRect != null)
				{
					ctx.ctx.Rect(clipRect.x, clipRect.y, clipRect.width, clipRect.height);
					ctx.ctx.Clip();
				}

				if (matrix != null)
				{
					ctx.SetTransform(matrix.a, matrix.b, matrix.c, matrix.d, matrix.tx, matrix.ty);
				}

				if (blendMode != null)
				{
					ctx.blendMode = blendMode;
				}

				sourceDisplayObject.draw(ctx);
				internalImage = result;
				ctx.ctx.Restore();
			}

		}

		public virtual void drawWithQuality(IBitmapDrawable source, Matrix matrix = null, ColorTransform colorTransform = null, string blendMode = null, Rectangle clipRect = null, bool smoothing = false, string quality = null)
		{
			draw(source, matrix, colorTransform, blendMode, clipRect, smoothing);
		}

		public virtual void fillRect(Rectangle rect, uint color)
		{
			for (var x = (int)rect.x; x < rect.x + rect.width; x++)
				for (var y = (int)rect.y; y < rect.y + rect.height; y++)
				{
					setPixel32(x, y, color);
				}
		}

		extern public virtual void floodFill(int x, int y, uint color);

		extern public virtual Rectangle generateFilterRect(Rectangle sourceRect, BitmapFilter filter);

		extern public virtual Rectangle getColorBoundsRect(uint mask, uint color, bool findColor = true);

		public virtual ByteArray getPixels(Rectangle rect)
		{
			var data = new ByteArray();
			copyPixelsToByteArray(rect, data);
			return data;
		}

		//[API("682")]
		public virtual void copyPixelsToByteArray(Rectangle rect, ByteArray data)
		{
			for (var x = (uint)rect.x; x < (rect.x + rect.width); x++)
				for (var y = (uint)rect.y; y < (rect.y + rect.height); y++)
				{
					var i = x + y * imageData.Width;
					data.writeByte(imageData.Data[i]);
					data.writeByte(imageData.Data[i + 1]);
					data.writeByte(imageData.Data[i + 2]);
					if (transparent)
						data.writeByte(imageData.Data[i + 3]);
				}
		}

		//[Version("10")]
		public virtual Vector<uint> getVector(Rectangle rect)
		{
			var i = 0;
			var result = new Vector<uint>((int)rect.width * (int)rect.height);
			for (var x = (int)rect.x; x < rect.x + rect.width; x++)
				for (var y = (int)rect.y; y < rect.y + rect.height; y++)
				{
					result[i++] = getPixel32(x, y);
				}
			return result;
		}

		extern public virtual bool hitTest(Point firstPoint, uint firstAlphaThreshold, Object secondObject, Point secondBitmapDataPoint = null, uint secondAlphaThreshold = 1);

		extern public virtual void merge(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, uint redMultiplier, uint greenMultiplier, uint blueMultiplier, uint alphaMultiplier);

		extern public virtual void noise(int randomSeed, uint low = 0, uint high = 255, uint channelOptions = 7, bool grayScale = false);

		extern public virtual void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, Array redArray = null, Array greenArray = null, Array blueArray = null, Array alphaArray = null);

		extern public virtual void perlinNoise(double baseX, double baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise, uint channelOptions = 7, bool grayScale = false, Array offsets = null);

		extern public virtual int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint,	int randomSeed = 0, int numPixels = 0, uint fillColor = 0);

		extern public virtual void scroll(int x, int y);

		public virtual void setPixels(Rectangle rect, ByteArray inputByteArray)
		{
			for (var x = (int)rect.x; x < rect.x + rect.width; x++)
			{
				for (var y = (int)rect.y; y < rect.y + rect.height; y++)
					setPixel32(x, y, inputByteArray.readUnsignedInt());
			}
		}

		//[Version("10")]
		public virtual void setVector(Rectangle rect, Vector<uint> inputVector)
		{
			var i = 0;
			for (var x = (int)rect.x; x < rect.x + rect.width; x++)
				for (var y = (int)rect.y; y < rect.y + rect.height; y++)
				{
					setPixel32(x, y, inputVector[i++]);
				}
		}

		extern public virtual uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint,
			string operation, uint threshold, uint color = 0, uint mask = 0xffffffff, bool copySource = false);

		extern public virtual void @lock();

		extern public virtual void unlock(Rectangle changeRect = null);

		//[Version("10")]
		extern public virtual Vector<Vector<double>> histogram(Rectangle hRect = null);

		//[API("680")]
		extern public virtual ByteArray encode(Rectangle rect, Object compressor, ByteArray byteArray = null);

		public int width
		{
			get { return _width; }
			set
			{
				_width = value;
				changed();
			}
		}

		public int height
		{
			get { return _height; }
			set
			{
				_height = value;
				changed();
			}
		}

		public string url
		{
			get { return _url; }
			set { _url = value; }
		}

		public bool transparent { get; protected set; }

		public Rectangle rect
		{
			get { return new Rectangle(0, 0, width, height); }
		}

		public Any<HTMLImageElement, HTMLVideoElement, HTMLCanvasElement, CanvasRenderingContext2D> internalImage
		{
			get
			{
				return _internalImage;
			}

			set
			{
				_internalImage = value;
			}
		}

		private Any<HTMLImageElement, HTMLVideoElement, HTMLCanvasElement, CanvasRenderingContext2D> _internalImage;

		private int _height;
		private int _width;
		private bool _canDraw = true;

		internal void drawSelf(CanvasRenderingContext2D ctx, double x, double y, double width, double height, double rx = 0, double ry = 0, double rw = 1, double rh = 1)
		{
			if (!canDraw)
				return;

			var image = internalImage.FastAs<CanvasRenderingContext2D>() == null ? internalImage : internalImage.FastAs<CanvasRenderingContext2D>().Canvas;
			if (image == null)
				return;

			ctx.DrawImage(image, rx * this.width, ry * this.height, rw * this.width, rh * this.height, x, y, width, height);
		}

		internal void drawSelf(CanvasRenderingContext2D ctx, double x, double y, double width, double height)
		{
			if (!canDraw)
				return;

			var image = internalImage.FastAs<CanvasRenderingContext2D>() == null ? internalImage : internalImage.FastAs<CanvasRenderingContext2D>().Canvas;
			if (image == null)
				return;

			ctx.DrawImage(image, x, y, width, height);
		}
	}
}