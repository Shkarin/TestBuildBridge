//===================================

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
using SoundTransform = flash.media.SoundTransform;

namespace flash.display
{
	//[native(instance="SimpleButtonObject",methods="auto",cls="SimpleButtonClass",gc="exact")]
	public class SimpleButton : InteractiveObject
	{
		private DisplayObject _currentState;

		private DisplayObject currentState
		{
			get
			{
				if (_currentState == null)
				{
					currentState = upState;
					changed();
				}
				return _currentState;
			}
			set
			{
				_currentState = value;
				changed();
			}
		}

		protected void AS3_ctor(DisplayObject upState = null, DisplayObject overState = null, DisplayObject downState = null,
			DisplayObject hitTestState = null)
		{
			base.AS3_ctor();
			if (upState)
			{
				this.upState = upState;
			}
			
			if (overState)
			{
				this.overState = overState;
			}
			
			if (downState)
			{
				this.downState = downState;
			}
			
			if (hitTestState)
			{
				this.hitTestState = hitTestState;
			}
			
			addEventListener(MouseEvent.MOUSE_OVER, (Action<MouseEvent>)onMouseEvent);
			addEventListener(MouseEvent.MOUSE_OUT, (Action<MouseEvent>)onMouseEvent);
			addEventListener(MouseEvent.MOUSE_DOWN, (Action<MouseEvent>)onMouseEvent);
			addEventListener(MouseEvent.MOUSE_UP, (Action<MouseEvent>)onMouseEvent);
			currentState = upState;
		}

		private bool mouseDown;
		private void onMouseEvent(MouseEvent e)
		{
			switch (e.type)
			{
				case MouseEvent.MOUSE_OVER:
					currentState = mouseDown ? _downState : _overState;
					Mouse.cursor = Cursor.Pointer.toString();
					break;
				case MouseEvent.MOUSE_OUT:
					Mouse.cursor = Cursor.Default.toString();
					currentState = _upState;
					break;
				case MouseEvent.MOUSE_DOWN:
					currentState = _downState;
					mouseDown = true;
					break;
				case MouseEvent.MOUSE_UP:
					currentState = _upState;
					mouseDown = false;
					break;
			}
		}

		public override void draw(RenderingContext context)
		{
			if (currentState != null)
			{
				currentState.draw(context);
			}
		}

		public override bool hitTestPoint(double x, double y, bool shapeFlag = false)
		{
			if (hitTestState != null)
				return hitTestState.hitTestPoint(x,y, shapeFlag);
			
			return overState != null && overState.hitTestPoint(x, y, shapeFlag);
		}

		public SimpleButton(DisplayObject upState = null, DisplayObject overState = null, DisplayObject downState = null,
			DisplayObject hitTestState = null)
		{
			AS3_ctor(upState, overState, downState, hitTestState);
		}

		private bool _useHandCursor;

		public virtual bool _get_useHandCursor()
		{
			return _useHandCursor;
		}

		public virtual void _set_useHandCursor(bool value)
		{
			_useHandCursor = value;
		}

		private bool _enabled;

		public virtual bool _get_enabled()
		{
			return _enabled;
		}

		public virtual void _set_enabled(bool value)
		{
			_enabled = value;
		}

		private bool _trackAsMenu;

		public virtual bool _get_trackAsMenu()
		{
			return _trackAsMenu;
		}

		public virtual void _set_trackAsMenu(bool value)
		{
			_trackAsMenu = value;
		}


		private DisplayObject _upState;

		public virtual DisplayObject _get_upState()
		{
			return _upState;
		}

		public virtual void _set_upState(DisplayObject value)
		{
			_upState = value;
		}

		private DisplayObject _overState;

		public virtual DisplayObject _get_overState()
		{
			return _overState;
		}

		public virtual void _set_overState(DisplayObject value)
		{
			_overState = value;
		}

		private DisplayObject _downState;

		public virtual DisplayObject _get_downState()
		{
			return _downState;
		}

		public virtual void _set_downState(DisplayObject value)
		{
			_downState = value;
		}

		private DisplayObject _hitTestState;

		public virtual DisplayObject _get_hitTestState()
		{
			return _hitTestState;
		}

		public virtual void _set_hitTestState(DisplayObject value)
		{
			_hitTestState = value;
		}

		extern public virtual SoundTransform _get_soundTransform();

		extern public virtual void _set_soundTransform(SoundTransform sndTransform);

		public bool useHandCursor
		{
			get { return _get_useHandCursor(); }
			set { _set_useHandCursor(value); }
		}

		public bool enabled
		{
			get { return _get_enabled(); }
			set { _set_enabled(value); }
		}

		public bool trackAsMenu
		{
			get { return _get_trackAsMenu(); }
			set { _set_trackAsMenu(value); }
		}

		public DisplayObject upState
		{
			get { return _get_upState(); }
			set { _set_upState(value); }
		}

		public DisplayObject overState
		{
			get { return _get_overState(); }
			set { _set_overState(value); }
		}

		public DisplayObject downState
		{
			get { return _get_downState(); }
			set { _set_downState(value); }
		}

		public DisplayObject hitTestState
		{
			get { return _get_hitTestState(); }
			set { _set_hitTestState(value); }
		}

		public SoundTransform soundTransform
		{
			get { return _get_soundTransform(); }
			set { _set_soundTransform(value); }
		}

		public override Rectangle getBounds(DisplayObject targetCoordinateSpace, Rectangle result = null)
		{
			if (result == null)
			{
				result = new Rectangle();
			}

			result.setEmpty();

			if (currentState == null)
			{
				return result;
			}

			currentState.getBounds(currentState, result);
			getTargetSpaceRect(targetCoordinateSpace, result, result);
			return result;
		}
	}
}
