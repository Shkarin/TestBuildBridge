//===================================
using System;
using Bridge.Html5;
using flash.display;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.filters
{
	//[native(instance="GlowFilterObject",methods="auto",cls="GlowFilterClass")]
	public /*final*/ class GlowFilter
	{
		private string colorString;

		public GlowFilter(uint color = 16711680, double alpha = 1.0, double blurX = 6.0, double blurY = 6.0,
			double strength = 2, int quality = 1, bool inner = false, bool knockout = false)
		{
			
		}

		public uint color
		{
			get; set;
		}

		public double alpha
		{
			get; set;
		}

		public double blurX
		{
			get; set;
		}

		public double blurY
		{
			get; set;
		}

		public bool inner
		{
			get; set;
		}

		public bool knockout
		{
			get; set;
		}

		public int quality
		{
			get; set;
		}

		public double strength
		{
			get; set;
		}
	}
}
