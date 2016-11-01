

using System;
using as3;
using Bridge.Html5;
using flash.geom;
using flash.ui;
using flash.xml;
using MouseEvent = flash.events.MouseEvent;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================
using Rectangle = flash.geom.Rectangle;
using SoundTransform = flash.media.SoundTransform;

namespace flash.display
{
	//[native(instance="SpriteObject",methods="auto",cls="SpriteClass",gc="exact")]
	public class Sprite : DisplayObjectContainer
	{
		private Graphics _graphics = new Graphics();
		protected void AS3_ctor()
		{
			base.AS3_ctor();
			constructChildren();
			_graphics.Changed += changed;
		}
		
		public Sprite()
		{
			AS3_ctor();
		}

		public Graphics _get_graphics()
		{
			return _graphics;
		}

		private bool _buttonMode;

		public virtual bool _get_buttonMode()
		{
			return _buttonMode;
		}

		public virtual void _set_buttonMode(bool value)
		{
			_buttonMode = value;
			_set_useHandCursor(value);
		}

		internal override void drawSelf(RenderingContext context)
		{
			if (needScale9Grid)
				graphics.draw(context, this, isMaskChild, (int)x, (int)y, scaleX, scaleY, scale9Grid);
			else
				graphics.draw(context, isMaskChild);
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

		public virtual DisplayObject _get_dropTarget()
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

		private Point tmpCoord = new Point();

		public override InteractiveObject getObjectUnderPoint(double localX, double localY)
		{
			if (_hitArea != null)
			{
				tmpCoord.setTo(localX, localY);
				localToGlobal(tmpCoord, tmpCoord);
				_hitArea.globalToLocal(tmpCoord, tmpCoord);
				if (!_hitArea.hitTestPoint(tmpCoord.x, tmpCoord.y))
					return null;
			}

			var o = base.getObjectUnderPoint(localX, localY);
			if (o != null)
				return o;

			if (graphics.hitTest(localX, localY) || _hitArea != null)
				return this;
	
			return null;
		}

		public virtual void _set_useHandCursor(bool value)
		{
			_useHanCursor = value;
			if (value)
			{
				if (_buttonMode)
				{
					addEventListener(MouseEvent.ROLL_OVER, (Action<MouseEvent>)handEventsHandler);
					addEventListener(MouseEvent.ROLL_OUT, (Action<MouseEvent>)handEventsHandler);
				}
				addEventListener(MouseEvent.MOUSE_OVER, (Action<MouseEvent>)handEventsHandler);
				addEventListener(MouseEvent.MOUSE_OUT, (Action<MouseEvent>)handEventsHandler);
				addEventListener(MouseEvent.MOUSE_MOVE, (Action<MouseEvent>)handEventsHandler);
			}
			else
			{
				removeEventListener(MouseEvent.ROLL_OVER, (Action<MouseEvent>)handEventsHandler);
				removeEventListener(MouseEvent.ROLL_OUT, (Action<MouseEvent>)handEventsHandler);
				removeEventListener(MouseEvent.MOUSE_OVER, (Action<MouseEvent>)handEventsHandler);
				removeEventListener(MouseEvent.MOUSE_OUT, (Action<MouseEvent>)handEventsHandler);
				removeEventListener(MouseEvent.MOUSE_MOVE, (Action<MouseEvent>)handEventsHandler);
			}
		}

		private void handEventsHandler(MouseEvent e)
		{
			if (stage == null)
				return;

			switch (e.type)
			{
				case MouseEvent.MOUSE_OUT:
					Mouse.cursor = Cursor.Default.toString();
					break;
				case MouseEvent.MOUSE_MOVE:
				case MouseEvent.MOUSE_OVER:
					Mouse.cursor = Cursor.Pointer.toString();
					break;
			}
		}

		public override bool hitTestPoint(double x, double y, bool shapeFlag = false)
		{
			return base.hitTestPoint(x, y, shapeFlag) || graphics.hitTest(x, y);
		}

		private SoundTransform _soundTransform;

		public virtual SoundTransform _get_soundTransform()
		{
			return _soundTransform;
		}

		public virtual void _set_soundTransform(SoundTransform sndTransform)
		{
			_soundTransform = sndTransform;
		}

		public Graphics graphics
		{
			get { return _get_graphics(); }
		}

		public bool buttonMode
		{
			get { return _get_buttonMode(); }
			set { _set_buttonMode(value); }
		}

		public DisplayObject dropTarget
		{
			get { return _get_dropTarget(); }
		}

		public Sprite hitArea
		{
			get { return _get_hitArea(); }
			set { _set_hitArea(value); }
		}

		public bool useHandCursor
		{
			get { return _get_useHandCursor(); }
			set { _set_useHandCursor(value); }
		}

		public SoundTransform soundTransform
		{
			get { return _get_soundTransform(); }
			set { _set_soundTransform(value); }
		}

		protected void setGraphics(string imageGuid, double x, double y, double width, double height, double bitmapWidth,
			double bitmapHeight)
		{
            graphics.setGraphics(imageGuid, x, y, width, height);
            //graphics.setImage(imageGuid, x, y, width, height);
		}

		private readonly Rectangle tempRectangle = new Rectangle();
		public override Rectangle getBounds(DisplayObject targetCoordinateSpace, Rectangle result = null)
		{
			if (result == null)
				result = new Rectangle();
			else
				result.setEmpty();
			tempRectangle.setEmpty();
			if (targetCoordinateSpace == null)
				targetCoordinateSpace = this;

			base.getBounds(targetCoordinateSpace, result);
			graphics.getBounds(targetCoordinateSpace, this, tempRectangle);

			result.union(tempRectangle, result);

			var offset = getOffsetFilter();
			result.inflate(offset, offset);

			return result;
		}
	}
}