namespace GraphSearchShortPath
{
    partial class DisplayGraph
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
            this.numPerc = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.pctBoxDisp = new System.Windows.Forms.PictureBox();
            this.txtBoxOut = new System.Windows.Forms.TextBox();
            this.rdioDepth = new System.Windows.Forms.RadioButton();
            this.rdioBreadth = new System.Windows.Forms.RadioButton();
            this.rdioDijkstra = new System.Windows.Forms.RadioButton();
            this.numVerts = new System.Windows.Forms.NumericUpDown();
            this.lblVert = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerts)).BeginInit();
            this.SuspendLayout();
            // 
            // numPerc
            // 
            this.numPerc.Font = new System.Drawing.Font("Stencil", 10F);
            this.numPerc.Location = new System.Drawing.Point(183, 31);
            this.numPerc.Name = "numPerc";
            this.numPerc.Size = new System.Drawing.Size(109, 23);
            this.numPerc.TabIndex = 2;
            this.numPerc.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Stencil", 20F);
            this.btnRun.Location = new System.Drawing.Point(298, 7);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(303, 49);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Press To Reprocess";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pctBoxDisp
            // 
            this.pctBoxDisp.Location = new System.Drawing.Point(16, 62);
            this.pctBoxDisp.Name = "pctBoxDisp";
            this.pctBoxDisp.Size = new System.Drawing.Size(1092, 730);
            this.pctBoxDisp.TabIndex = 7;
            this.pctBoxDisp.TabStop = false;
            // 
            // txtBoxOut
            // 
            this.txtBoxOut.Location = new System.Drawing.Point(1114, 62);
            this.txtBoxOut.Multiline = true;
            this.txtBoxOut.Name = "txtBoxOut";
            this.txtBoxOut.Size = new System.Drawing.Size(369, 730);
            this.txtBoxOut.TabIndex = 8;
            // 
            // rdioDepth
            // 
            this.rdioDepth.AutoSize = true;
            this.rdioDepth.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioDepth.Location = new System.Drawing.Point(607, 12);
            this.rdioDepth.Name = "rdioDepth";
            this.rdioDepth.Size = new System.Drawing.Size(279, 33);
            this.rdioDepth.TabIndex = 9;
            this.rdioDepth.TabStop = true;
            this.rdioDepth.Text = "Depth First Search";
            this.rdioDepth.UseVisualStyleBackColor = true;
            this.rdioDepth.CheckedChanged += new System.EventHandler(this.rdioDepth_CheckedChanged);
            // 
            // rdioBreadth
            // 
            this.rdioBreadth.AutoSize = true;
            this.rdioBreadth.Font = new System.Drawing.Font("Stencil", 18F);
            this.rdioBreadth.Location = new System.Drawing.Point(892, 12);
            this.rdioBreadth.Name = "rdioBreadth";
            this.rdioBreadth.Size = new System.Drawing.Size(312, 33);
            this.rdioBreadth.TabIndex = 10;
            this.rdioBreadth.TabStop = true;
            this.rdioBreadth.Text = "Breadth First Search";
            this.rdioBreadth.UseVisualStyleBackColor = true;
            this.rdioBreadth.CheckedChanged += new System.EventHandler(this.rdioBreadth_CheckedChanged);
            // 
            // rdioDijkstra
            // 
            this.rdioDijkstra.AutoSize = true;
            this.rdioDijkstra.Font = new System.Drawing.Font("Stencil", 16F);
            this.rdioDijkstra.Location = new System.Drawing.Point(1210, 7);
            this.rdioDijkstra.Name = "rdioDijkstra";
            this.rdioDijkstra.Size = new System.Drawing.Size(273, 56);
            this.rdioDijkstra.TabIndex = 11;
            this.rdioDijkstra.TabStop = true;
            this.rdioDijkstra.Text = "Dijkstra\'s Shortest \r\nPath";
            this.rdioDijkstra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdioDijkstra.UseVisualStyleBackColor = true;
            this.rdioDijkstra.CheckedChanged += new System.EventHandler(this.rdioDijkstra_CheckedChanged);
            // 
            // numVerts
            // 
            this.numVerts.Font = new System.Drawing.Font("Stencil", 10F);
            this.numVerts.Location = new System.Drawing.Point(123, 3);
            this.numVerts.Name = "numVerts";
            this.numVerts.Size = new System.Drawing.Size(169, 23);
            this.numVerts.TabIndex = 12;
            this.numVerts.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblVert
            // 
            this.lblVert.AutoSize = true;
            this.lblVert.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVert.Location = new System.Drawing.Point(12, 3);
            this.lblVert.Name = "lblVert";
            this.lblVert.Size = new System.Drawing.Size(105, 22);
            this.lblVert.TabIndex = 16;
            this.lblVert.Text = "Verticies";
            this.lblVert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Font = new System.Drawing.Font("Stencil", 14F);
            this.lblPerc.Location = new System.Drawing.Point(12, 31);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(171, 22);
            this.lblPerc.TabIndex = 18;
            this.lblPerc.Text = "Percentage Fill";
            this.lblPerc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisplayGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 804);
            this.Controls.Add(this.lblPerc);
            this.Controls.Add(this.lblVert);
            this.Controls.Add(this.numVerts);
            this.Controls.Add(this.rdioDijkstra);
            this.Controls.Add(this.rdioBreadth);
            this.Controls.Add(this.rdioDepth);
            this.Controls.Add(this.txtBoxOut);
            this.Controls.Add(this.pctBoxDisp);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.numPerc);
            this.Name = "DisplayGraph";
            this.Text = "DisplayGraph";
            ((System.ComponentModel.ISupportInitialize)(this.numPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numPerc;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox pctBoxDisp;
        private System.Windows.Forms.TextBox txtBoxOut;
        private System.Windows.Forms.RadioButton rdioDepth;
        private System.Windows.Forms.RadioButton rdioBreadth;
        private System.Windows.Forms.RadioButton rdioDijkstra;
        private System.Windows.Forms.NumericUpDown numVerts;
        private System.Windows.Forms.Label lblVert;
        private System.Windows.Forms.Label lblPerc;
    }
}