using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFT_week_4
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
	public class Initial_DFT_Square_Matrix : Matrix
	{
		int padded_size;
		public Initial_DFT_Square_Matrix(int size) 
			: base(size)
        {
			size = this.size;
			padded_size = fix_size();
			values = new int[size];
        }
		public int fix_size()
		{
			if (!Mathematic_Functions.check_if_power_of_2(size))
				return find_additional_size_needed();
			else
				return size;
		}
		public void pad_with_zero(int additional_size)
		{

		}
		public int find_additional_size_needed()
        {
			int closest_power_of_2 = Convert.ToInt32(Math.Log(size, 2) - Math.Log(size, 2) % 1);
			int closest_power_of_2_rounded_up = 2 ^ (closest_power_of_2 + 1);
			return closest_power_of_2_rounded_up - size;
        }
		public void fill_matrix()
        {

        }
		public Complex_Number fundemental_frequency(double n)
        {
			Complex_Number i = Mathematic_Functions.i();
			return Math.Exp((-2 * Math.PI * i) * (1/n));
			
        }
	}
	public class DFT_Square_Matrix : Matrix
    {
		public DFT_Square_Matrix(int size)
			: base(size)
		{

		}
	}

}
