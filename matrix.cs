using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guassian_Elimination
{
    public class Matrix
    {
		public int[] values;
		public int size;
		public Matrix(int size)
		{
			this.size = size;
			values = new int[size*size];
		}
	}

}
