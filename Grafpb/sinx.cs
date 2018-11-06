﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafpb
{
   class sinx 
    {
        // Задаём функцию для построения и пределы значения X.
        private double xMin = -Math.PI * 2;
        private double xMax = Math.PI * 2;
        public double Interval
        {
            get { return xMax - xMin; }
        }
        public float f(double x)
        {
            if (x == 0)
                return 1;
            return (float)(Math.Sin(x));
        }
        // Массив точек.
        private PointF[] listOfPoints;
        public PointF[] ListOfPoints

        {
            get { return listOfPoints; }
            private set { listOfPoints = value; }
        }
       
       public  sinx(int numberOfPoints)
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
