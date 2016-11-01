//===================================
using System;
using as3;
using Bridge.Html5;
using flash.display;
using flash.geom;
using flash.text;
using flash.xml;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.filters
{
	//[native(instance="BlurFilterObject",methods="auto",cls="BlurFilterClass")]
	public class BlurFilter : BitmapFilter
	{
		protected void AS3_ctor(double blurX = 4.0, double blurY = 4.0, int quality = 1)
		{
			base.AS3_ctor();
			this.blurX = blurX;
			this.blurY = blurY;
			this.quality = quality;
		}

		public BlurFilter(double blurX = 4.0, double blurY = 4.0, int quality = 1)
		{
			AS3_ctor(blurX, blurY, quality);
		}

		override public BitmapFilter clone()
		{
			return new BlurFilter(blurX, blurY, quality);
		}

		public override void apply(BitmapData sourceBitmapData, Rectangle sourceRect, BitmapData destBitmapData,
			Point destPoint)
		{
			throw new System.NotImplementedException();
		}

		public override void apply(Bridge.Html5.CanvasRenderingContext2D context, GlyphInstance glyph)
		{
			apply(context);
		}

		public override void apply(Bridge.Html5.CanvasRenderingContext2D context)
		{
			context["filter"] = "blur(" + (int)as3.Math.max(blurX, blurY) + "px)";
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
