//===================================

using System;

namespace flash.display
{
	//[native(instance="SimpleButtonObject",methods="auto",cls="SimpleButtonClass",gc="exact")]
	public class SimpleButton
	{
		private object _currentState;

		public SimpleButton(object upState = null, object overState = null, object downState = null,
			object hitTestState = null)
		{
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


		private object _upState;

		public virtual object _get_upState()
		{
			return _upState;
		}

		public virtual void _set_upState(object value)
		{
			_upState = value;
		}

		private object _overState;

		public virtual object _get_overState()
		{
			return _overState;
		}

		public virtual void _set_overState(object value)
		{
			_overState = value;
		}

		private object _downState;

		public virtual object _get_downState()
		{
			return _downState;
		}

		public virtual void _set_downState(object value)
		{
			_downState = value;
		}

		private object _hitTestState;

		public virtual object _get_hitTestState()
		{
			return _hitTestState;
		}

		public virtual void _set_hitTestState(object value)
		{
			_hitTestState = value;
		}

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

		public object upState
		{
			get { return _get_upState(); }
			set { _set_upState(value); }
		}

		public object overState
		{
			get { return _get_overState(); }
			set { _set_overState(value); }
		}

		public object downState
		{
			get { return _get_downState(); }
			set { _set_downState(value); }
		}

		public object hitTestState
		{
			get { return _get_hitTestState(); }
			set { _set_hitTestState(value); }
		}
	}
}
