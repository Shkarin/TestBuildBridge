//===================================
using as3;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.display
{
	//[native(instance="MovieClipObject",methods="auto",cls="MovieClipClass",gc="exact")]
	public /*dynamic*/ class MovieClip
	{
		private object frames;
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


		public void setGraphics(string v1, int v2, int v3, double v4, double v5, int v6, int v7)
		{
		}
		public void setFrames(object frames)
		{
		}

		public object addChild(object value)
		{
			return null;
		}

		private int _currentFrame;

		public virtual int _get_currentFrame()
		{
			return _currentFrame;
		}

		public virtual int _get_framesLoaded()
		{
			return _get_totalFrames();
		}

		public virtual int _get_totalFrames()
		{
			return frames == null ? 0 : 0;
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

		public virtual void play()
		{
			if (_isPlaying)
				return;
			_isPlaying = true;
		}

		private void onEnterFrame()
		{
		}

		public virtual void stop()
		{
			if (!_isPlaying)
				return;
			_isPlaying = false;
		}


		public virtual void nextFrame()
		{
		}

		public virtual void prevFrame()
		{
		}

		public virtual void gotoAndPlay(object frame, string scene = null)
		{
		}

		public virtual void gotoAndPlay(int frame, string scene = null)
		{
		}

		public virtual void gotoAndPlay(string frame, string scene = null)
		{
		}

		public virtual void gotoAndStop(object frame, string scene = null)
		{
		}

		public virtual void gotoAndStop(int frame, string scene = null)
		{
		}

		public virtual void gotoAndStop(string frame, string scene = null)
		{
		}

        //[Inspectable(environment="none")]
        public virtual void addFrameScript(int frameId, System.Action action)
        {
        }

		public object dispatchEvent(object s)
		{
			return null;
		}

		//[Version("10")]

		extern public virtual void prevScene();

		extern public virtual void nextScene();

		protected bool _enabled;

		public virtual bool _get_enabled()
		{
			return _enabled;
		}

		public virtual void _set_enabled(bool value)
		{
			_enabled = value;
		}

        private bool _isPlaying;

		public virtual bool _get_isPlaying()
		{
			return _isPlaying;
		}

		public int currentFrame
		{
			get { return _get_currentFrame(); }
		}

		public int framesLoaded
		{
			get { return _get_framesLoaded(); }
		}

		public int totalFrames
		{
			get { return _get_totalFrames(); }
		}

		public bool trackAsMenu
		{
			get { return _get_trackAsMenu(); }
			set { _set_trackAsMenu(value); }
		}


		public bool enabled
		{
			get { return _get_enabled(); }
			set { _set_enabled(value); }
		}

		public bool isPlaying
		{
			get { return _get_isPlaying(); }
		}

		public dynamic dynamics
		{
			get { return this; }
		}
	}
}
