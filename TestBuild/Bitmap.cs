//===================================
using as3;
using flash.geom;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.display
{
	//[native(instance="BitmapObject",methods="auto",cls="BitmapClass",gc="exact")]
	public class Bitmap 
	{
		private BitmapData _bitmapData;
		public object filters;
		public double x = 0;
		public double y = 0;
		public double scaleX = 0;
		public double scaleY = 0;
		public double alpha = 0;
		public double rotation;
		public object mask;
		public object scale9Grid;
		public bool visible;
		public object blendMode;
		protected void AS3_ctor(BitmapData bitmapData = null, string pixelSnapping = "auto", bool smoothing = false)
		{
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
			}
		}
	}
}
