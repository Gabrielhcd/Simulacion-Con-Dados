using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionDados
{
	class Dado
	{
		int dice;
		Random rand = new Random();
		public int lanzar()
		{
			dice = rand.Next(1, 7);
			return dice;
		}
		
	}
}
