namespace GraphSearchShortPath
{
    partial class GraphSearchShortPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.numRowCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numColCount = new System.Windows.Forms.NumericUpDown();
            this.numPercFill = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.butRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercFill)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(13, 56);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(775, 382);
            this.txtDisplay.TabIndex = 0;
            // 
            // numRowCount
            // 
            this.numRowCount.Location = new System.Drawing.Point(13, 30);
            this.numRowCount.Name = "numRowCount";
            this.numRowCount.Size = new System.Drawing.Size(90, 20);
            this.numRowCount.TabIndex = 1;
            this.numRowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numRowCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Row Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Column Count";
            // 
            // numColCount
            // 
            this.numColCount.Location = new System.Drawing.Point(109, 30);
            this.numColCount.Name = "numColCount";
            this.numColCount.Size = new System.Drawing.Size(90, 20);
            this.numColCount.TabIndex = 2;
            this.numColCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numColCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numPercFill
            // 
            this.numPercFill.Location = new System.Drawing.Point(205, 30);
            this.numPercFill.Name = "numPercFill";
            this.numPercFill.Size = new System.Drawing.Size(90, 20);
            this.numPercFill.TabIndex = 5;
            this.numPercFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPercFill.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percentage To Fill";
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(705, 9);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(82, 44);
            this.butRun.TabIndex = 7;
            this.butRun.Text = "Click Here To Reprocess";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // GraphSearchShortPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPercFill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numColCount);
            this.Controls.Add(this.numRowCount);
            this.Controls.Add(this.txtDisplay);
            this.Name = "GraphSearchShortPath";
            this.Text = "Graph Search and Shortest Path";
            this.Load += new System.EventHandler(this.formGraphSearchShortPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.NumericUpDown numRowCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numColCount;
        private System.Windows.Forms.NumericUpDown numPercFill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butRun;
    }
}

