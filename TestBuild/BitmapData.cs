//===================================

using System;

namespace flash.display
{
	//[native(instance="BitmapDataObject",methods="auto",cls="BitmapDataClass",gc="exact")]
	public class BitmapData
	{
		public event Action Changed;
		public event Action CanDraw;

		protected int width = 0;
		protected int height = 0;
		protected bool transparent = false;
		protected string _url = null;


		public BitmapData(int width = 0, int height = 0, bool transparent = true, uint fillColor = 0xffffffff)
		{
		}

		public void setPixels(string value)
		{
		}
	}
}