using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphSearchShortPath
{
    public partial class GraphSearchShortPath : Form
    {
        GenerateArray generator = new GenerateArray();
        public int[,] arr;
        public double perc;
        public int rows;
        public int cols;

        public GraphSearchShortPath()
        {
            InitializeComponent();
            rows = (int)numRowCount.Value;
            cols = (int)numColCount.Value;
            perc = (double)numPercFill.Value;
            arr = new int[rows, cols];
            formGraphSearchShortPath_Load(this, null);
        }

        public void formGraphSearchShortPath_Load(object sender, EventArgs e)
        {
            generator.genArr(arr, perc);
            txtDisplay.Text = generator.testDisplay(arr);
        }

        private void butRun_Click(object sender, EventArgs e)
        {
            rows = (int)numRowCount.Value;
            cols = (int)numColCount.Value;
            perc = (double)numPercFill.Value;
            arr = new int[rows, cols];
            generator.genArr(arr, perc);
            txtDisplay.Text = generator.testDisplay(arr);
        }
    }
}
