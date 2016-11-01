//===================================
using System;
using as3;
using Bridge.Html5;
using flash.display;
using flash.geom;
using flash.text;
using flash.utils;
using flash.xml;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.filters
{
	//[native(instance="GlowFilterObject",methods="auto",cls="GlowFilterClass")]
	public /*final*/ class GlowFilter : BitmapFilter
	{
		private string colorString;
		protected void AS3_ctor(uint color = 16711680, double alpha = 1.0, double blurX = 6.0, double blurY = 6.0,
			double strength = 2, int quality = 1, bool inner = false, bool knockout = false)
		{
			base.AS3_ctor();
			this.color = color;
			this.alpha = alpha;
			this.blurX = blurX;
			this.blurY = blurY;
			this.quality = quality;
			this.strength = strength;
			this.inner = inner;
			this.knockout = knockout;
			colorString = Color.toRGBA(color, alpha).toString();
		}

		public GlowFilter(uint color = 16711680, double alpha = 1.0, double blurX = 6.0, double blurY = 6.0,
			double strength = 2, int quality = 1, bool inner = false, bool knockout = false)
		{
			AS3_ctor(color, alpha, blurX, blurY, strength, quality, inner, knockout);
		}

		override public BitmapFilter clone()
		{
			return new GlowFilter(color, alpha, blurX, blurY, strength, quality, inner, knockout);
		}

		public override void apply(BitmapData sourceBitmapData, Rectangle sourceRect, BitmapData destBitmapData,
			Point destPoint)
		{
			throw new System.NotImplementedException();
		}

		public override void apply(Bridge.Html5.CanvasRenderingContext2D ctx, GlyphInstance glyph)
		{
			var margin = (int)glyph.format.size;
			var totalWidth = glyph.width + blur * 2 + margin;
			var totalHeight = glyph.height + blur * 2 + margin;

			for (var i = 0; i < quality; i++)
			{
				ctx.Save();
				ctx.BeginPath();
				ctx.Rect(glyph.x - blur, glyph.y + blur + margin, totalWidth, -totalHeight - margin);
				ctx.Clip();

				drawShadow(ctx, glyph, totalWidth, 0, -1);
				drawShadow(ctx, glyph, totalWidth, 1, -1);
				drawShadow(ctx, glyph, totalWidth, 1, 0);
				drawShadow(ctx, glyph, totalWidth, 1, 1);
				drawShadow(ctx, glyph, totalWidth, 0, 1);
				drawShadow(ctx, glyph, totalWidth, -1, 1);
				drawShadow(ctx, glyph, totalWidth, -1, 0);
				drawShadow(ctx, glyph, totalWidth, -1, -1);

				ctx.Restore();
			}
		}

		private float blur
		{
			get
			{
				return (float)as3.Math.max(blurX, blurY);
			}
		}

		private void drawShadow(Bridge.Html5.CanvasRenderingContext2D ctx, GlyphInstance glyph, double totalWidth, int offsetX, int offsetY)
		{
			ctx.ShadowColor = colorString;
			ctx.ShadowBlur = blur;
			ctx.ShadowOffsetX = (float)(totalWidth) + offsetX;
			ctx.ShadowOffsetY = offsetY;
			ctx.FillText(glyph.text, (int)(glyph.x - totalWidth), (int)glyph.y);
		}

		public override void apply(Bridge.Html5.CanvasRenderingContext2D ctx)
		{
			drawGlow(ctx, 0, -1);
		}

		private void drawGlow(Bridge.Html5.CanvasRenderingContext2D ctx, int offsetX, int offsetY)
		{
			ctx.ShadowColor = colorString;
			ctx.ShadowBlur = blur;
			ctx.ShadowOffsetX = offsetX;
			ctx.ShadowOffsetY = offsetY;
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
