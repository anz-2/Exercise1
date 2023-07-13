using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
	internal class Triangle : Shape
	{
		public override int CalculatePerimeter(int gverdi1, int gverdi2)
		{
			return gverdi1 * gverdi2 / 2;
		}
	}
}
