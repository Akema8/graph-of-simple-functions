using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafpb
{
    class sqrtx
    {
        // Задаём функцию для построения и пределы значения X.
        private double xMin = 0;
        private double xMax = 20;
        public double Interval
        {
            get { return xMax - xMin; }
        }
        public float f(double x)
        {
            if (x == 0)
                return 0;
            return (float)(Math.Sqrt(x));
        }
        // Массив точек.
        private PointF[] listOfPoints;
        public PointF[] ListOfPoints
        {
            get { return listOfPoints; }
            private set { listOfPoints = value; }
        }

        public sqrtx(int numberOfPoints)
        {

            listOfPoints = new PointF[numberOfPoints];
            // Шаг по X
            double StepByX = Interval / numberOfPoints;
            // Заполняем массив точек.
            double x;
            for (int i = 0; i < numberOfPoints; i++)
            {
                x = StepByX * i + xMin;
                listOfPoints[i] = new PointF((float)x, f(x));
            }
        }
    }
}
