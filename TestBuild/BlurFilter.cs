//===================================
using System;
using as3;
using Bridge.Html5;
using flash.display;

//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.filters
{
	//[native(instance="BlurFilterObject",methods="auto",cls="BlurFilterClass")]
	public class BlurFilter 
	{

		public BlurFilter(double blurX = 4.0, double blurY = 4.0, int quality = 1)
		{

		}

		public double blurX
		{
			get; set;
		}

		public double blurY
		{
			get;set;
		}

		public int quality
		{
			get; set;
		}
	}
}
