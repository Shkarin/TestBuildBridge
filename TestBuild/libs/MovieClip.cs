//===================================
using as3;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.display
{
	//[native(instance="MovieClipObject",methods="auto",cls="MovieClipClass",gc="exact")]
	public /*dynamic*/ class MovieClip : Sprite
	{
		private Frames frames;
		protected void AS3_ctor()
		{
            base.AS3_ctor();
		}

		public MovieClip()
		{
			AS3_ctor();
		}

		public void setFrames(Frames frames)
		{
			this.frames = frames;
			acceptFrame(frames[0]);
            if (this.frames.count > 1)
                gotoAndPlay(1);
		}

        internal override void onFrame()
        {
            base.onFrame();

            if (isPlaying)
                onEnterFrame();
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
			return frames == null ? 0 : frames.count;
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
			if (totalFrames == 0)
				return;
			acceptFrame(frames[(currentFrameInfo.id + 1) % totalFrames]);
		}

		public virtual void stop()
		{
			if (!_isPlaying)
				return;
			_isPlaying = false;
		}

		private FrameInfo currentFrameInfo;
		private void acceptFrame(FrameInfo frame)
		{
			if (currentFrameInfo == frame)
				return;

			for (var i = 0; i < frame.actions.Count; i++)
			{
				frame.actions[i]();
			}
            
            for (var i = numChildren - 1; i >= 0; i--)
            {
                if (frame.objects.IndexOf(getChildAt(i)) != -1)
                    continue;
                removeChildAt(i);
            }
            for (var i = 0; i < frame.objects.Count; i++)
            {
                if (contains(frame.objects[i]))
                    continue;
                addChildAt(frame.objects[i], i);
                if (frame.objects[i] is MovieClip)
                    (frame.objects[i] as MovieClip).gotoAndPlay(1);
            }
            _currentFrame = frame.id;
			currentFrameInfo = frame;
		}

		public virtual void nextFrame()
		{
			if (totalFrames == 0)
				return;

			var index = (currentFrameInfo.id - 1);
			if (index >= totalFrames)
				index = totalFrames - 1;
			acceptFrame(frames[index]);
		}

		public virtual void prevFrame()
		{
			if (totalFrames == 0)
				return;

			var index = (currentFrameInfo.id - 1);
			if (index < 0)
				index = 0;
			acceptFrame(frames[index]);
		}

		public virtual void gotoAndPlay(Object frame, string scene = null)
		{
			if (frames == null) // TODO: remove
				return;

			acceptFrame(frames[frame]);
			play();
		}

		public virtual void gotoAndPlay(int frame, string scene = null)
		{
			if (frames == null) // TODO: remove
				return;

            //in SWF frames from 1
			acceptFrame(frames[frame - 1]);
			play();
		}

		public virtual void gotoAndPlay(string frame, string scene = null)
		{
			if (frames == null) // TODO: remove
				return;

			acceptFrame(frames[frame]);
			play();
		}

		public virtual void gotoAndStop(Object frame, string scene = null)
		{
			if (frames == null) // TODO: remove
				return;

			acceptFrame(frames[frame]);
			stop();
		}

		public virtual void gotoAndStop(int frame, string scene = null)
		{
			if (frames == null) // TODO: remove
				return;

            //in SWF frames from 1
            acceptFrame(frames[frame - 1]);
			stop();
		}

		public virtual void gotoAndStop(string frame, string scene = null)
		{
			if (frames == null) // TODO: remove
				return;

			acceptFrame(frames[frame]);
			stop();
		}

        //[Inspectable(environment="none")]
        public virtual void addFrameScript(int frameId, System.Action action)
        {
            frames[frameId].actions.Add(action);
        }
		extern public virtual Array _get_scenes();

		extern public virtual Scene _get_currentScene();

		public virtual string _get_currentLabel()
		{
			return currentFrameInfo.label;
		}

		//[Version("10")]
		public virtual string _get_currentFrameLabel()
		{
			return currentFrameInfo.label;
		}

		public virtual Array _get_currentLabels()
		{
			return currentScene.labels;
		}

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

		public Array scenes
		{
			get { return _get_scenes(); }
		}

		public Scene currentScene
		{
			get { return _get_currentScene(); }
		}

		public string currentLabel
		{
			get { return _get_currentLabel(); }
		}

		public string currentFrameLabel
		{
			get { return _get_currentFrameLabel(); }
		}

		public Array currentLabels
		{
			get { return _get_currentLabels(); }
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
