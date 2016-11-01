//===================================
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
	//[native(instance="ColorMatrixFilterObject",methods="auto",cls="ColorMatrixFilterClass")]
	public /*final*/ class ColorMatrixFilter : BitmapFilter
	{
		private Array _matrix = new Array();
		protected void AS3_ctor(Array matrix = null)
		{
			base.AS3_ctor();
			if (matrix != null)
				this.matrix = matrix;
		}

		public ColorMatrixFilter(Array matrix = null)
		{
			AS3_ctor(matrix);
		}

		public virtual Array _get_matrix()
		{
			return this._matrix;
		}

		public virtual void _set_matrix(Array value)
		{
			this._matrix = matrix;
		}

		public override BitmapFilter clone()
		{
			return new ColorMatrixFilter(matrix);
		}

		public override void apply(BitmapData sourceBitmapData, Rectangle sourceRect, BitmapData destBitmapData,
			Point destPoint)
		{
			throw new System.NotImplementedException();
		}

		public override void apply(Bridge.Html5.CanvasRenderingContext2D context, GlyphInstance glyph)
		{
			throw new System.NotImplementedException();
		}

		public override void apply(Bridge.Html5.CanvasRenderingContext2D context)
		{
			//throw new System.NotImplementedException();
		}

		public Array matrix
		{
			get { return _get_matrix(); }
			set { _set_matrix(value); }
		}
	}
}
