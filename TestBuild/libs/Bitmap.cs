//===================================
using as3;
using flash.geom;
using flash.xml;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.display
{
	//[native(instance="BitmapObject",methods="auto",cls="BitmapClass",gc="exact")]
	public class Bitmap : DisplayObject
	{
		private BitmapData _bitmapData;

		protected void AS3_ctor(BitmapData bitmapData = null, string pixelSnapping = "auto", bool smoothing = false)
		{
			base.AS3_ctor();
			ctor(bitmapData, pixelSnapping, smoothing);
		}

		public Bitmap(BitmapData bitmapData = null, string pixelSnapping = "auto", bool smoothing = false)
		{
			AS3_ctor(bitmapData, pixelSnapping, smoothing);
		}

		private void ctor(BitmapData bitmapData, string pixelSnapping, bool smoothing)
		{
			this.bitmapData = bitmapData;
			this.pixelSnapping = pixelSnapping;
			this.smoothing = smoothing;
		}

		public string pixelSnapping { get; set; }

		public bool smoothing { get; set; }

		public BitmapData bitmapData
		{
			get { return _bitmapData; }
			set
			{
				if (_bitmapData != null)
				{
					_bitmapData.Changed -= changed;
				}
				_bitmapData = value;
				if (_bitmapData != null)
				{
					_bitmapData.Changed += changed;
				}
				this.changed();
			}
		}

		public override void draw(RenderingContext context)
		{
			if (needScale9Grid)
			{
				context.DrawScale9Grid(bitmapData, (int)x, (int)y, (int)width, (int)height, scale9Grid);
				return;
			}
			context.DrawImage(bitmapData, 0, 0, bitmapData.width, bitmapData.height);
		}

		public override bool hitTestPoint(double x, double y, bool shapeFlag = false)
		{
			return x >= 0 && y >= 0 && x < bitmapData.width && y < bitmapData.height;
		}

		public override Rectangle getRect(DisplayObject targetCoordinateSpace, Rectangle result = null)
		{
			if (result == null)
				result = new Rectangle();
			result.setTo(0, 0, bitmapData == null ? 0 : bitmapData.width, bitmapData == null ? 0 : bitmapData.height);

			getTargetSpaceRect(targetCoordinateSpace, result, result);
			return result;
		}

		public override Rectangle getBounds(DisplayObject targetCoordinateSpace, Rectangle result = null)
		{
			if (result == null)
				result = new Rectangle();

			getRect(targetCoordinateSpace, result);

			var offset = getOffsetFilter();
			result.inflate(offset, offset);

			return result;
		}

		public override double origWidth()
		{
			if (bitmapData == null)
				return 0;

			return bitmapData.width;
		}

		public override double origHeight()
		{
			if (bitmapData == null)
				return 0;

			return bitmapData.height;
		}
	}
}
