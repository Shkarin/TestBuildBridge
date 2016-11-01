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
	//[native(instance="ShapeObject",methods="auto",cls="ShapeClass",gc="exact")]
	public class Shape : DisplayObject
	{

		protected void AS3_ctor()
		{
			base.AS3_ctor();
			_graphics.Changed += changed;
		}

		public Shape()
		{
			AS3_ctor();
		}

		protected Graphics _graphics = new Graphics();

		public virtual Graphics _get_graphics()
		{
			return _graphics;
		}

		public Graphics graphics
		{
			get { return _get_graphics(); }
		}

		public override void draw(RenderingContext context)
		{
			graphics.draw(context, isMaskChild);
		}

        public string graphicsHash
        {
            set { setGraphics(value, 0, 0, 0, 0, 0, 0); }
        }

		protected void setGraphics(string imageGuid, double x, double y, double width, double height, double bitmapWidth, double bitmapHeight)
		{
            graphics.setGraphics(imageGuid, x, y, width, height);
        }

		public override bool hitTestPoint(double x, double y, bool shapeFlag = false)
		{
			if (graphics.hitTest(x, y))
			{
				return true;
			}
			return base.hitTestPoint(x, y, shapeFlag);
		}

		public override Rectangle getBounds(DisplayObject targetCoordinateSpace, Rectangle result = null)
		{
			if (result == null)
				result = new Rectangle();

			if (targetCoordinateSpace == null)
				targetCoordinateSpace = this;

			return graphics.getBounds(targetCoordinateSpace, this, result);
		}
	}
}
