using circleOfLines;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearchShortPath
{
    public class CirclesAndLinesDisplay : CreateCircle
    {
        //IAD 10/15/2024: Used to add the nodes/circles to the display
        public Bitmap addCircle(Bitmap orig, int row, int column, int color)
        {
            int cellSize = 100;
            Bitmap newBitmap = new Bitmap(orig.Width + 60, orig.Height + 60);
            Graphics g = Graphics.FromImage(newBitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(orig, 0, 0);
            int[] rgb = setColor(color);
            Bitmap newCircleBitmap = CreateCircle.circleMaker((byte)rgb[0], (byte)rgb[1], (byte)rgb[2], 20, 30);
            int xPos = column * cellSize + (cellSize - newCircleBitmap.Width) / 2;
            int yPos = row * cellSize + (cellSize - newCircleBitmap.Height) / 2;
            g.DrawImage(newCircleBitmap, xPos, yPos);
            return newBitmap;
        }
        //IAD 10/15/2024: Used to draw/add lines in the display
        public Bitmap addLine(Bitmap orig, int row, int column, int color)
        {
            int cellSize = 100;
            Bitmap newBitmap = new Bitmap(orig.Width + 60, orig.Height + 60);
            Graphics g = Graphics.FromImage(newBitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(orig, 0, 0);
            int[] rgb = setColor(color);
            Bitmap newLineBitmap = CreateCircle.circleMaker((byte)rgb[0], (byte)rgb[1], (byte)rgb[2], 2, 30);
            int xPos = column * cellSize + (cellSize - newLineBitmap.Width) / 2;
            int yPos = row * cellSize + (cellSize - newLineBitmap.Height) / 2;

            g.DrawImage(newLineBitmap, xPos, yPos);
            return newBitmap;
        }
        //IAD 10/15/2024: Draws the nodes that are visible in the display.
        public void DrawNode(Graphics g, Point position, int color, int nodeRadius, string label)
        {
            int[] rgb = setColor(color);
            Bitmap nodeBitmap = CreateCircle.circleMaker((byte)rgb[0], (byte)rgb[1], (byte)rgb[2], 20, nodeRadius);
            int xPos = position.X - nodeRadius;
            int yPos = position.Y - nodeRadius;
            g.DrawImage(nodeBitmap, xPos, yPos);
            using (Font font = new Font("Arial", 12))
            {
                SizeF textSize = g.MeasureString(label, font);
                PointF textPosition = new PointF(position.X - textSize.Width / 2, position.Y - textSize.Height / 2);
                g.DrawString(label, font, Brushes.Black, textPosition);
            }
        }
        //IAD 10/15/2024: Draws the edges that are visible in the display.
        public void DrawEdge(Graphics g, Point from, Point to, int color)
        {
            float edgeThickness = 3.0f;
            Pen pen = new Pen(Color.FromArgb(setColor(color)[0], setColor(color)[1], setColor(color)[2]), edgeThickness);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(6, 6);
            pen.CustomEndCap = bigArrow;

            g.DrawLine(pen, from, to);
        }

        //IAD 10/15/2024: Overloaded DrawEdge method for weighted edges
        public void DrawEdge(Graphics g, Point from, Point to, int color, int weight)
        {
            float edgeThickness = 3.0f;
            Pen pen = new Pen(Color.FromArgb(setColor(color)[0], setColor(color)[1], setColor(color)[2]), edgeThickness);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(6, 6);
            pen.CustomEndCap = bigArrow;

            g.DrawLine(pen, from, to);
            PointF weightPosition = new PointF((from.X + to.X) / 2, (from.Y + to.Y) / 2);
            using (Font font = new Font("Arial", 10))
            {
                SizeF textSize = g.MeasureString(weight.ToString(), font);
                PointF textPos = new PointF(weightPosition.X - textSize.Width / 2, weightPosition.Y - textSize.Height / 2);
                g.DrawString(weight.ToString(), font, Brushes.Black, textPos);
            }
        }

        //IAD 10/15/2024: Returns an RGB value for coloring the graph's nodes
        public int[] setColor(int c)
        {
            int[] rgb = new int[3];

            // Black (default edge and unvisited node)
            if (c == 0) { rgb[0] = 0; rgb[1] = 0; rgb[2] = 0; }
            // Blue (visited node)
            else if (c == 1) { rgb[0] = 0; rgb[1] = 0; rgb[2] = 255; }
            // Red (path edge)
            else if (c == 2) { rgb[0] = 255; rgb[1] = 0; rgb[2] = 0; }

            return rgb;
        }
    }
}
