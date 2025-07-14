/*********************************************************************************************
 * Daniel Richards
 * 6/8/2012
 * This class makes the line circle and sends it back as a bitmap
*********************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace circleOfLines
{
    //IAD 10/11/2024: Made public for external use
    public class CreateCircle
    {
        private static double angleRadians;
        private static Point origin = new Point(0, 0);
        private static Point result = new Point(0, 0);
        private static List<Point> pointList = new List<Point>();
        private static Pen circlePen;
        private static Bitmap circleBitmap;
        private static Color circleColor;
        private static Graphics circleGraphic;

        //main method in this class. returns a bitmap for use in the caller method
        public static Bitmap circleMaker(byte redValue, byte greenValue, byte blueValue, int numPoints, int radius)
        {
            angleRadians = Math.PI * 2 / numPoints;
            circleColor = Color.FromArgb(redValue, greenValue, blueValue);
            circlePen = new Pen(circleColor);

            originOffset(radius);
            findPoints(numPoints, radius);
            drawLines(numPoints, radius);
            return circleBitmap;
        }

        //offsets the origin by the radius
        private static void originOffset(int radius)
        {
            origin.X = radius; 
            origin.Y = radius;
        }

        //calculating points
        private static void findPoints(int numPoints, int radius)
        {
            pointList.Clear(); //necessary, otherwise, the list won't start from scratch on the second try
            for (int i = 1; i <= numPoints; i++)
            {
                //the following lines I stole off the internet and slightly modified
                result.Y = origin.Y + (int)Math.Round(radius * Math.Sin(angleRadians * i));
                result.X = origin.X + (int)Math.Round(radius * Math.Cos(angleRadians * i));
                if (!pointList.Contains(result))
                {
                    pointList.Add(result);
                }
            }
        }

        //drawing lines
        private static void drawLines(int numPoints, int radius)
        {
            circleBitmap = new Bitmap(radius * 2, radius * 2);
            circleGraphic = Graphics.FromImage(circleBitmap);
            for (int i = 0; i < numPoints; i++)
                for (int j = i; j < numPoints; j++)
                    circleGraphic.DrawLine(circlePen, pointList[i], pointList[j]);
        }
    }
    //IAD 10/11/2024: Using radius 10 and 0 for all colors for Project 4
}
