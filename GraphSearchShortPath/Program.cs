/*********************************************************************************************
 * Daniel Richards
 * 6/8/2012
 * This program creates a circle of lines from user input and displays it.
*********************************************************************************************/
using GraphSearchShortPath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace circleOfLines
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisplayGraph());
        }
    }
}
