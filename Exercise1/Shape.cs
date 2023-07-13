using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
	public class Shape
	{
		public virtual int CalculatePerimeter(int length, int width)
		{
			return (length + width) * 2;
		}
	}
}
