//===================================
using as3;
using Bridge.Html5;
using flash.display;
using flash.geom;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.filters
{
	//[native(instance="ColorMatrixFilterObject",methods="auto",cls="ColorMatrixFilterClass")]
	public /*final*/ class ColorMatrixFilter
	{
		private Array _matrix = new Array();

		public ColorMatrixFilter(Array matrix = null)
		{
			
		}

		public virtual Array _get_matrix()
		{
			return this._matrix;
		}

		public virtual void _set_matrix(Array value)
		{
			this._matrix = matrix;
		}

		public Array matrix
		{
			get { return _get_matrix(); }
			set { _set_matrix(value); }
		}
	}
}
