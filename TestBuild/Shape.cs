//===================================
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.display
{
	//[native(instance="ShapeObject",methods="auto",cls="ShapeClass",gc="exact")]
	public class Shape
	{
		public Shape()
		{
		}

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
		public object graphicsHash;

		//"9a478cc8e74a234eab39e08d6022f4a9", -20.25, -20.25, 40.5, 40.5, 1, 1
		public void setGraphics(string v1, double v2, double v3, double v4, double v5, int v6, int v7)
		{
		}
	}
}
