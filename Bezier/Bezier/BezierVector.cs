using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierVector
{
	public class Vector
	{
		public float x { get; private set; }
		public float y { get; private set; }

		public Vector(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		//public static Vector operator *(Vector a, float b)
		//{
		//	return new Vector(a.x * b, a.y * b);
		//}

		//public static Vector operator +(Vector a, Vector b)
		//{
		//	return new Vector(a.x + b.x, a.y + b.y);
		//}
	}
}