using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionDados
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Dado dice = new Dado();
		Dado dice2 = new Dado();
		int cara; string dado;
		int[] frecuencia = new int[7];
		int[] sumaFrecuencia = new int[13];

		private void btnlanzar_Click(object sender, EventArgs e)
		{

			dado = Convert.ToString(dice.lanzar());
			txtlanzamientos.Text = dado;
		}

		private void btnlanzar100_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 100; i++)
			{
				cara = dice.lanzar();
				frecuencia[cara]++;
			}
			for(int i = 1; i < 7; i++)
			{
				dado = "La cara " + i + " cayo " + frecuencia[i] + " veces";
				txtlanzamientos.Text += dado + Environment.NewLine;
			}
		}
		private void btn2x100_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 100; i++)
			{
				cara = dice.lanzar() + dice.lanzar();
				sumaFrecuencia[cara]++;
			}
			for(int i =1; i < 13; i++)
			{
				dado = "La suma " + i + " cayo " + sumaFrecuencia[i] + " veces";
				txtlanzamientos.Text += dado + Environment.NewLine;
			}
		}
		private void btn1p1x100_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 100; i++)
			{
				cara = dice.lanzar() + dice2.lanzar();
				sumaFrecuencia[cara]++;
			}
			for(int i = 1; i < 13; i++)
			{
				dado = "La suma " + i + " cayo " + sumaFrecuencia[i] + " veces";
				txtlanzamientos.Text += dado + Environment.NewLine;
			}
		}
	}
}
