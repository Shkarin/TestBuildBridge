using System.Collections.Generic;
using System;
using as3;
using System.Collections;
using System.Linq;
using Bridge;

namespace as3
{
	public class Array : Object, IEnumerable<Object>
	{
		public static uint DESCENDING = 2;

		public static uint UNIQUESORT = 4;

		public static uint RETURNINDEXEDARRAY = 8;

		public static uint NUMERIC = 16;

		private Vector<Object> vector = null;

		public Array()
		{
			this.vector = new Vector<Object>();
		}

		public Array(int length)
		{
			this.vector = new Vector<Object>(length);
		}

		public Array(object[] objects)
		{
			this.vector = new Vector<Object>();

			for (var i = 0; i < objects.Length; i++)
				Add(Object.dynamicCast(objects[i]));
		}

		public Array(Object[] objects)
		{
			this.vector = new Vector<Object>();

			for (var i = 0; i < objects.Length; i++)
				Add(objects[i]);
		}

		static public Array MakeArray(object[] objects)
		{
			if (objects == null)
				return null;
			var array = new Array();
			for (var i = 0; i < objects.Length; i++)
			{
				array.Add(Object.dynamicCast(objects[i]));
			}
			return array;
		}

		static public implicit operator Array(Object[] objects)
		{
			return MakeArray(objects);
		}

		public void Add(Object obj)
		{
			vector.Add(obj);
		}

		public int push(params Object[] obj)
		{
			return vector.push(obj);
		}

		public Object pop()
		{
			return vector.pop();
		}

		public void sort(uint type = 0)
		{
			this.vector.sort();
		}

		public int indexOf(Object item)
		{
			return vector.IndexOf(item);
		}

		public int unshift(params Object[] obj)
		{
			foreach (var o in obj)
			{
				vector.Insert(0, o);
			}

			return vector.Count;
		}

		public Object shift()
		{
			var obj = this[0];
			vector.RemoveAt(0);
			return obj;
		}

		public override Object this[object key]
		{
			get
			{
				if (key is string || key is asString)
					return getPropertyValue(key);
				return dynamicCast(this[(int)key]);
			}
			set
			{
				if (key is string || key is asString)
					setPropertyValue(key, value);
				else
					this[(int)key] = value.As<Object>();
			}
		}

		public Object this[uint index]
		{
			get
			{
				return vector[(uint)index];
			}
			set
			{
				vector[(uint)index] = value;
			}
		}

		public Object this[int index]
		{
			get
			{
				if (index >= vector.Count || index < 0)
					return null;
				return vector[(int)index];
			}
			set
			{
				vector[(int)index] = value;
			}
		}

		public string join(string separator = ",")
		{
			return string.Join(separator, (IEnumerable<Object>)vector);
		}

		public override int length
		{
			get { return vector.Count; }
			set
			{
				vector.length = value;
			}
		}

		public void sort(Func<Object, Object, int> sortSlot, Object options = null)
		{
			this.vector.sort(sortSlot);
		}

		public void sort(Function sortSlot, Object options = null)
		{
			sort((Func<Object, Object, int>)sortSlot, options);
		}

		public Array concat()
		{
			var result = new Array();

			result.AddRange(this.vector);
			return result;
		}

		public Array concat(params Object[] args)
		{
			var result = new Array();

			result.AddRange(this.vector);

			for (var i = 0; i < args.Length; i++)
			{
				result.AddRange(args[i]._getObjectValues());
			}

			return result;
		}

		public Array slice(int start = 0)
		{
			return slice(start, this.length);
		}
		
		public Array slice(uint start, uint end)
		{
			var array = new Array();
			for (var i = start; i < end; i++)
				array.Add(this[i]);
			return array;
		}

		public Array slice(int start, int end)
		{
			return slice((uint)start, (uint)end);
		}

		public Array sortOn(Object filedName, Object options = null)
		{
			var isNumeric = checkOption(options, (int)Array.NUMERIC);
			var isDescending = checkOption(options, (int)Array.DESCENDING);

			vector.sort(delegate(as3.Object o1, as3.Object o2)
			{
				if (isNumeric)
				{
					if ((int) o1[filedName] >= (int) o2[filedName])
						return isDescending ? -1 : 1;

					if ((int)o1[filedName] < (int)o2[filedName])
						return isDescending ? 1 : -1;
				}

				if (String.Compare(o1[filedName], o2[filedName]) == 1)
					return isDescending ? -1 : 1;
				if (String.Compare(o1[filedName], o2[filedName]) == -1)
					return isDescending ? 1 : -1;

				return 0;
			});

			return null;
		}

		public Array splice(int start, int deleteCount = int.MaxValue, params as3.Object[] addElements)
		{
			var result = new Array(deleteCount);
			while (deleteCount-- > 0 && start < this.length)
			{
				result.Add(this[start]);
				vector.RemoveAt(start);
			}
			vector.AddRange(addElements);
			return result;
		}

		public Array filter(params Object[] objectsfunc)
		{
			Function a = objectsfunc[0] as Function;
			var array = new Array();
			for (var i = 0; i < this.length; i++)
			{
				if (a.invoke(this[i], i, this))
					array.Add(this[i]);
			}
			return array;
		}

		internal override IEnumerable<Object> _getObjectValuesImpl()
		{
			foreach (var key in _getObjectKeysImpl())
				yield return dynamicCast(vector[key.As<int>()]);
		}

		internal override IEnumerable<string> _getObjectKeysImpl()
		{
			for (var i = 0; i < vector.Count; i++)
			{
				yield return i.toString();
			}
		}

		public IEnumerator<Object> GetEnumerator()
		{
			return vector.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return vector.GetEnumerator();
		}

		public dynamic dynamics { get { return this; } }

		public override string toString()
		{
			return this.vector.ToArray().toString();
		}

		public override bool hasProperty(object key)
		{
			if (!(key is int))
				return base.hasProperty(key);

			if ((int)key >= vector.Count)
				return false;
			return (int)key >= 0;
		}

		private void AddRange(IEnumerable<Object> v)
		{
			vector.AddRange(v);
		}

		private void AddRange(Vector<Object> v)
		{
			vector.AddRange(v);
		}

		private bool checkOption(Object options, int type)
		{
			if (options == null)
				return false;
			if (options is as3.Array)
				return (options as as3.Array).vector.indexOf(type) != -1;
			var op = (int)options;
			return (op & type) == type;
		}
	}
}