using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafpb
{
    class GenOsiXY
    {
        public GenOsiXY(PointF[] listOfPoints, int width, int height, Graphics g)
        {
            Pen a = new Pen(Color.Blue, 1); //цвет размер осей
            Pen b = new Pen(Color.Green, 1); //цвет размер функция
            Font drawFont = new Font("Arial", 12);
            Font signatureFont = new Font("Arial", 7);
            SolidBrush drawBrash = new SolidBrush(Color.Blue);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            Point center = new Point(((int)(width / 2)), (int)((height / 2))); // (0,0)
            //для рисования осей
            g.DrawLine(a, 10, center.Y, 2 * center.X - 10, center.Y); 
            g.DrawLine(a, center.X, 10, center.X, center.Y * 2 - 10);
 

            g.DrawString("X", drawFont, drawBrash, new PointF(2 * center.X - 5, center.Y + 10), drawFormat);
            g.DrawString("Y", drawFont, drawBrash, new PointF(center.X + 30, 5), drawFormat);

            //перемещаем точки функции на центр оси
            for (int i = 0; i < listOfPoints.Length; i++)
            {
                listOfPoints[i].X = listOfPoints[i].X *30 + center.X; //20 - размер масштабируемости
                listOfPoints[i].Y = (-1)*listOfPoints[i].Y *30+ center.Y;
            }
       //     g.DrawCurve(b, listOfPoints);
            // Рисуем точки.
            g.DrawLines(b, listOfPoints);

        }
    }
}
