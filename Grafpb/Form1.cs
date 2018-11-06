using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grafpb
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex;    // Выделенная строка
            if (n == -1) return;
            Graphics g = GrafWind.CreateGraphics();
            switch (n)
            {
                case 0:
                    g.Clear(Color.White);
                    xPow2 gFGenerator0 = new xPow2(100);
                    GenOsiXY gIGenerator0 = new GenOsiXY(gFGenerator0.ListOfPoints, GrafWind.Width, GrafWind.Height, g);
                    break;
                case 1:
                    g.Clear(Color.White);
                    xPow3 gFGenerator1 = new xPow3(100);
                    GenOsiXY gIGenerator1 = new GenOsiXY(gFGenerator1.ListOfPoints, GrafWind.Width, GrafWind.Height, g);
                    break;
                case 2:
                    g.Clear(Color.White);
                    cosx gFGenerator2 = new cosx(100);
                    GenOsiXY gIGenerator2 = new GenOsiXY(gFGenerator2.ListOfPoints, GrafWind.Width, GrafWind.Height, g);
                    break;
                case 3:
                    g.Clear(Color.White);
                    sinx gFGenerator3 = new sinx(100);
                    GenOsiXY gIGenerator3 = new GenOsiXY(gFGenerator3.ListOfPoints, GrafWind.Width, GrafWind.Height, g);
                    break;
                case 4:
                    g.Clear(Color.White);
                    tgx gFGenerator4 = new tgx(100);
                    GenOsiXY gIGenerator4 = new GenOsiXY(gFGenerator4.ListOfPoints, GrafWind.Width, GrafWind.Height, g);
                    break;
                case 5:
                    g.Clear(Color.White);
                    lnx gFGenerator5 = new lnx(100);
                    GenOsiXY gIGenerator5 = new GenOsiXY(gFGenerator5.ListOfPoints, GrafWind.Width, GrafWind.Height, g);
                    break;
                case 6:
                    g.Clear(Color.White);
                    sqrtx gFGenerator6 = new sqrtx(100);
                    GenOsiXY gIGenerator6 = new GenOsiXY(gFGenerator6.ListOfPoints, GrafWind.Width, GrafWind.Height, g);
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
