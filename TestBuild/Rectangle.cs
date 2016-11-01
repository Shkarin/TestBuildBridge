//===================================
using as3;

//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.geom
{
	//[native(instance="RectangleObject",methods="auto",cls="RectangleClass",gc="exact")]
	public class Rectangle
	{

		public double x = 0;

		public double y = 0;

		public double width = 0;

		public double height = 0;

		protected void AS3_ctor(double x = 0, double y = 0, double width = 0, double height = 0)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

		public Rectangle(double x = 0, double y = 0, double width = 0, double height = 0)
		{
			AS3_ctor(x, y, width, height);
		}

		public virtual double _get_left()
		{
			return x;
		}

		public virtual void _set_left(double value)
		{
			width = width + (x - value);
			x = value;
		}

		public virtual double _get_right()
		{
			return x + width;
		}

		public virtual void _set_right(double value)
		{
			width = value - x;
		}

		public virtual double _get_top()
		{
			return y;
		}

		public virtual void _set_top(double value)
		{
			height = height + (y - value);
			y = value;
		}

		public virtual double _get_bottom()
		{
			return y + height;
		}

		public virtual void _set_bottom(double value)
		{
			height = value - y;
		}

		public virtual Rectangle clone()
		{
			return new Rectangle(x, y, width, height);
		}

		public virtual bool isEmpty()
		{
			return width <= 0 || height <= 0;
		}

		public virtual void setEmpty()
		{
			x = 0;
			y = 0;
			width = 0;
			height = 0;
		}

		public virtual void inflate(double dx, double dy)
		{
			x = x - dx;
			width = width + 2*dx;
			y = y - dy;
			height = height + 2*dy;
		}


		public virtual void offset(double dx, double dy)
		{
			x = x + dx;
			y = y + dy;
		}

		

		public virtual bool contains(double x, double y)
		{
			return x >= this.x && x < this.x + width && y >= this.y &&
			       y < this.y + height;
		}

	

		public virtual bool containsRect(Rectangle rect)
		{
			double r1 = rect.x + rect.width;
			double b1 = rect.y + rect.height;
			double r2 = x + width;
			double b2 = y + height;
			return rect.x >= x && rect.x < r2 && rect.y >= y && rect.y < b2 &&
			       r1 > x && r1 <= r2 && b1 > y && b1 <= b2;
		}

		public virtual Rectangle intersection(Rectangle toIntersect)
		{
			
			return null;
		}

		public virtual bool intersects(Rectangle toIntersect)
		{
			
			return true;
		}

		public virtual Rectangle union(Rectangle toUnion, Rectangle result = null)
		{
			
			return null;
		}

		public virtual bool equals(Rectangle toCompare)
		{
			return toCompare.x == x && toCompare.y == y &&
			       toCompare.width == width && toCompare.height == height;
		}

		public virtual string toString()
		{
			return "(x=" + x + ", y=" + y + ", w=" + width + ", h=" + height + ")";
		}

		//[API("674")]
		public virtual void copyFrom(Rectangle sourceRect)
		{
			x = sourceRect.x;
			y = sourceRect.y;
			width = sourceRect.width;
			height = sourceRect.height;
		}

		//[API("674")]
		public virtual void setTo(double xa, double ya, double widtha, double heighta)
		{
			x = xa;
			y = ya;
			width = widtha;
			height = heighta;
		}

		public void encapsulate(double x, double y)
		{
			if (x < left)
				left = x;
			if (y < top)
				top = y;
			if (x > right)
				right = x;
			if (y > bottom)
				bottom = y;
		}

		public double left
		{
			get { return _get_left(); }
			set { _set_left(value); }
		}

		public double right
		{
			get { return _get_right(); }
			set { _set_right(value); }
		}

		public double top
		{
			get { return _get_top(); }
			set { _set_top(value); }
		}

		public double bottom
		{
			get { return _get_bottom(); }
			set { _set_bottom(value); }
		}
	}
}
