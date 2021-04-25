using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BezierVector;
using BezierFormula;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{ 
			var B = new Bezier();
			var p0 = new Vector(1.0f, 1.0f);
			var p1 = new Vector(3.0f, 6.0f);
			var p2 = new Vector(6.0f, 3.0f);
			var p3 = new Vector(7.0f, 7.0f);
			var b = B.BezierFormula(p0, p1, p2, p3, 0.3f);
			Console.WriteLine(b.x);
			Console.WriteLine(b.y);
			Console.ReadLine();

		}
	}
}
