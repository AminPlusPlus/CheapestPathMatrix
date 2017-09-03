namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.locationName = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.Label();
            this.StartIndex = new System.Windows.Forms.TextBox();
            this.startlbl = new System.Windows.Forms.Label();
            this.endlbl = new System.Windows.Forms.Label();
            this.EndIndex = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richMatrix = new System.Windows.Forms.RichTextBox();
            this.richGraph = new System.Windows.Forms.RichTextBox();
            this.total = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(156, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(274, 31);
            this.title.TabIndex = 1;
            this.title.Text = "Cheapest Path Matrix";
            // 
            // locationName
            // 
            this.locationName.AutoSize = true;
            this.locationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationName.Location = new System.Drawing.Point(232, 73);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(54, 13);
            this.locationName.TabIndex = 2;
            this.locationName.Text = "Name File";
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Creator.Location = new System.Drawing.Point(1, 459);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(266, 16);
            this.Creator.TabIndex = 3;
            this.Creator.Text = "All rights reserved by Aminjoni Abdullozoda";
            // 
            // StartIndex
            // 
            this.StartIndex.Location = new System.Drawing.Point(235, 113);
            this.StartIndex.Multiline = true;
            this.StartIndex.Name = "StartIndex";
            this.StartIndex.Size = new System.Drawing.Size(114, 22);
            this.StartIndex.TabIndex = 4;
            // 
            // startlbl
            // 
            this.startlbl.AutoSize = true;
            this.startlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startlbl.Location = new System.Drawing.Point(113, 115);
            this.startlbl.Name = "startlbl";
            this.startlbl.Size = new System.Drawing.Size(87, 20);
            this.startlbl.TabIndex = 5;
            this.startlbl.Text = "Start Index";
            // 
            // endlbl
            // 
            this.endlbl.AutoSize = true;
            this.endlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endlbl.Location = new System.Drawing.Point(113, 152);
            this.endlbl.Name = "endlbl";
            this.endlbl.Size = new System.Drawing.Size(81, 20);
            this.endlbl.TabIndex = 7;
            this.endlbl.Text = "End Index";
            // 
            // EndIndex
            // 
            this.EndIndex.Location = new System.Drawing.Point(235, 150);
            this.EndIndex.Multiline = true;
            this.EndIndex.Name = "EndIndex";
            this.EndIndex.Size = new System.Drawing.Size(114, 22);
            this.EndIndex.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(24, 193);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(243, 214);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richMatrix);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(235, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "The Matrix Is";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richMatrix
            // 
            this.richMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richMatrix.Location = new System.Drawing.Point(6, 6);
            this.richMatrix.Name = "richMatrix";
            this.richMatrix.ReadOnly = true;
            this.richMatrix.Size = new System.Drawing.Size(221, 176);
            this.richMatrix.TabIndex = 0;
            this.richMatrix.Text = "";
            // 
            // richGraph
            // 
            this.richGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richGraph.Location = new System.Drawing.Point(6, 3);
            this.richGraph.Name = "richGraph";
            this.richGraph.ReadOnly = true;
            this.richGraph.Size = new System.Drawing.Size(263, 179);
            this.richGraph.TabIndex = 0;
            this.richGraph.Text = "";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total.Location = new System.Drawing.Point(288, 425);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(90, 25);
            this.total.TabIndex = 10;
            this.total.Text = "Total Is";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(273, 193);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(283, 214);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richGraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(275, 188);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "The Cheapest Path is";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(564, 484);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.endlbl);
            this.Controls.Add(this.EndIndex);
            this.Controls.Add(this.startlbl);
            this.Controls.Add(this.StartIndex);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.locationName);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Cheapest Path Matrix";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label locationName;
        private System.Windows.Forms.Label Creator;
        private System.Windows.Forms.TextBox StartIndex;
        private System.Windows.Forms.Label startlbl;
        private System.Windows.Forms.Label endlbl;
        private System.Windows.Forms.TextBox EndIndex;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richMatrix;
        private System.Windows.Forms.RichTextBox richGraph;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

