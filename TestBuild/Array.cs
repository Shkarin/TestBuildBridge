using System.Collections.Generic;
using System;
using as3;
using System.Collections;
using System.Linq;
using Bridge;

namespace as3
{
	public class Array
	{
		public static uint DESCENDING = 2;

		public static uint UNIQUESORT = 4;

		public static uint RETURNINDEXEDARRAY = 8;

		public static uint NUMERIC = 16;

		public Array()
		{
			
		}

		public Array(object[] length)
		{

		}

		static public Array MakeArray(object[] objects)
		{
			return null;
		}

		static public implicit operator Array(Object[] objects)
		{
			return MakeArray(objects);
		}

		public void Add(Object obj)
		{
			
		}

		public int push(params Object[] obj)
		{
			return 0;
		}

		public Object pop()
		{
			return null;
		}

		public void sort(uint type = 0)
		{
			
		}

		public int indexOf(Object item)
		{
			return 0;
		}

		public int unshift(params Object[] obj)
		{
			return 0;
		}

		public Object shift()
		{
			return 0;
		}
	}
}