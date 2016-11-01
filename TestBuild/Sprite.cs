

using System;
using Bridge.Html5;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================
using Rectangle = flash.geom.Rectangle;

namespace flash.display
{
	//[native(instance="SpriteObject",methods="auto",cls="SpriteClass",gc="exact")]
	public class Sprite
	{
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
		public object addChild(object value)
		{
			return value;
		}

		public Sprite()
		{

		}

		private bool _buttonMode;

		public virtual bool _get_buttonMode()
		{
			return _buttonMode;
		}

		public virtual void _set_buttonMode(bool value)
		{
			_buttonMode = value;
		}

		extern public virtual void startDrag(bool lockCenter = false, Rectangle bounds = null);

		extern public virtual void stopDrag();

		//[API("667")]
		public virtual void startTouchDrag(int touchPointID, bool lockCenter = false, Rectangle bounds = null)
		{
			throw new NotImplementedException();
		}

		//[API("667")]
		public virtual void stopTouchDrag(int touchPointID)
		{
			throw new NotImplementedException();
		}

		protected virtual void constructChildren()
		{

		}

		private Sprite _hitArea;

		public virtual Sprite _get_hitArea()
		{
			return _hitArea;
		}

		public virtual void _set_hitArea(Sprite value)
		{
			_hitArea = value;
		}

		private bool _useHanCursor;

		public virtual bool _get_useHandCursor()
		{
			return _useHanCursor;
		}

	




	

		public bool buttonMode
		{
			get { return _get_buttonMode(); }
			set { _set_buttonMode(value); }
		}

	
		public Sprite hitArea
		{
			get { return _get_hitArea(); }
			set { _set_hitArea(value); }
		}

	
		protected void setGraphics(string imageGuid, double x, double y, double width, double height, double bitmapWidth,
			double bitmapHeight)
		{
		}
	}
}