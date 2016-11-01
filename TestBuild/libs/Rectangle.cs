//===================================
using as3;

using flash.xml;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.geom
{
	//[native(instance="RectangleObject",methods="auto",cls="RectangleClass",gc="exact")]
	public class Rectangle
		: Object
	{

		public double x = 0;

		public double y = 0;

		public double width = 0;

		public double height = 0;

		protected void AS3_ctor(double x = 0, double y = 0, double width = 0, double height = 0)
		{
			base.AS3_ctor();
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

		public virtual Point _get_topLeft()
		{
			return new Point(x, y);
		}

		public virtual void _set_topLeft(Point value)
		{
			width = width + (x - value.x);
			height = height + (y - value.y);
			x = value.x;
			y = value.y;
		}

		public virtual Point _get_bottomRight()
		{
			return new Point(right, bottom);
		}

		public virtual void _set_bottomRight(Point value)
		{
			width = value.x - x;
			height = value.y - y;
		}

		public virtual Point _get_size()
		{
			return new Point(width, height);
		}

		public virtual void _set_size(Point value)
		{
			width = value.x;
			height = value.y;
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

		public virtual void inflatePoint(Point point)
		{
			x = x - point.x;
			width = width + 2*point.x;
			y = y - point.y;
			height = height + 2*point.y;
		}

		public virtual void offset(double dx, double dy)
		{
			x = x + dx;
			y = y + dy;
		}

		public virtual void offsetPoint(Point point)
		{
			x = x + point.x;
			y = y + point.y;
		}

		public virtual bool contains(double x, double y)
		{
			return x >= this.x && x < this.x + width && y >= this.y &&
			       y < this.y + height;
		}

		public virtual bool containsPoint(Point point)
		{
			return point.x >= x && point.x < x + width && point.y >= y &&
			       point.y < y + height;
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
			Rectangle result = new Rectangle();
			bool a = isEmpty();
			if (a ? a : toIntersect.isEmpty())
			{
				result.setEmpty();
				return result;
			}
			;
			result.x = Math.max(x, toIntersect.x);
			result.y = Math.max(y, toIntersect.y);
			result.width = Math.min(x + width, toIntersect.x + toIntersect.width) - result.x;
			result.height = Math.min(y + height, toIntersect.y + toIntersect.height) - result.y;
			bool a1 = result.width <= 0;
			if (a1 ? a1 : result.height <= 0)
			{
				result.setEmpty();
			}
			;
			return result;
		}

		public virtual bool intersects(Rectangle toIntersect)
		{
			bool a = isEmpty();
			if (a ? a : toIntersect.isEmpty())
			{
				return false;
			}
			;
			double resultx = Math.max(x, toIntersect.x);
			double resulty = Math.max(y, toIntersect.y);
			double resultwidth = Math.min(x + width, toIntersect.x + toIntersect.width) - resultx;
			double resultheight = Math.min(y + height, toIntersect.y + toIntersect.height) - resulty;
			bool a1 = resultwidth <= 0;
			if (a1 ? a1 : resultheight <= 0)
			{
				return false;
			}
			;
			return true;
		}

		public virtual Rectangle union(Rectangle toUnion, Rectangle result = null)
		{
			if (result == null)
				result = new Rectangle();
			
			if (isEmpty())
			{
				result.copyFrom(toUnion);
				return result;
			}
			if (toUnion.isEmpty())
			{
				result.copyFrom(this);
				return result;
			}
			
			var x = Math.min(this.x, toUnion.x);
			var y = Math.min(this.y, toUnion.y);
			var width = Math.max(this.x + this.width, toUnion.x + toUnion.width) - x;
			var height = Math.max(this.y + this.height, toUnion.y + toUnion.height) - y;
			result.setTo(x, y, width, height);
			return result;
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

		public Point topLeft
		{
			get { return _get_topLeft(); }
			set { _set_topLeft(value); }
		}

		public Point bottomRight
		{
			get { return _get_bottomRight(); }
			set { _set_bottomRight(value); }
		}

		public Point size
		{
			get { return _get_size(); }
			set { _set_size(value); }
		}
	}
}
