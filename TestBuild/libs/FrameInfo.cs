using System;
using System.Collections.Generic;
using flash.display;

namespace as3
{
	public class Frames
	{
		public List<FrameInfo> frames;

		public Frames(int count = 0)
		{
			frames = new List<FrameInfo>(count);
		}

		public FrameInfo Add(string label = null)
		{
			FrameInfo frame = new FrameInfo(label);
			frame.id = frames.Count;
			this.frames.Add(frame);
			return frame;
		}

		public int count
		{
			get { return frames.Count; }
		}

		public FrameInfo this[Object i]
		{
			get
			{
				if (i is asInt)
					return this[(int) i];

				return this[(string) i];
			}
		}

		public FrameInfo this[int i]
		{
			get { return frames[i]; }
		}

		public FrameInfo this[string name]
		{
			get
			{
				for (var i = 0; i < frames.Count; i++)
				{
					var frameInfo = frames[i];
					if (frameInfo.label == name && frameInfo.label != null)
						return frameInfo;
				}
				return null;
			}
		}
	}

	public class FrameInfo
	{
		public int id;
		public string label = null;
		public List<Action> actions = new List<Action>();
		public List<DisplayObject> objects = new List<DisplayObject>();

		public FrameInfo(string label = null)
		{
			this.label = label;
		}

		public void Add(Action action)
		{
			actions.Add(action);
		}

		public void Add(DisplayObject obj)
		{
			objects.Add(obj);
		}

		static public FrameInfo operator +(FrameInfo left, Action right)
		{
			left.Add(right);
			return left;
		}
		static public FrameInfo operator +(FrameInfo left, DisplayObject right)
		{
			left.Add(right);
			return left;
		}
	}
}