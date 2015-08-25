namespace ABB_PC_SDK
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
            this.gbxControllerSelected = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnProduction1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxControllerSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxControllerSelected
            // 
            this.gbxControllerSelected.Controls.Add(this.label3);
            this.gbxControllerSelected.Controls.Add(this.label2);
            this.gbxControllerSelected.Controls.Add(this.btnProduction);
            this.gbxControllerSelected.Controls.Add(this.btnProduction1);
            this.gbxControllerSelected.Location = new System.Drawing.Point(12, 124);
            this.gbxControllerSelected.Name = "gbxControllerSelected";
            this.gbxControllerSelected.Size = new System.Drawing.Size(574, 227);
            this.gbxControllerSelected.TabIndex = 8;
            this.gbxControllerSelected.TabStop = false;
            this.gbxControllerSelected.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "What do you want to do with the selected Controller?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "";
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(6, 32);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(101, 36);
            this.btnProduction.TabIndex = 1;
            this.btnProduction.Tag = "";
            this.btnProduction.Text = "Start Production";
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click_1);
            // 
            // btnProduction1
            // 
            this.btnProduction1.Location = new System.Drawing.Point(113, 32);
            this.btnProduction1.Name = "btnProduction1";
            this.btnProduction1.Size = new System.Drawing.Size(101, 36);
            this.btnProduction1.TabIndex = 2;
            this.btnProduction1.Tag = "";
            this.btnProduction1.Text = "Stop Production";
            this.btnProduction1.UseVisualStyleBackColor = true;
            this.btnProduction1.Click += new System.EventHandler(this.btnProduction_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Double click a controller to select it.";
            this.label1.Visible = false;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(123, 37);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Enabled = false;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 266);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "";
            this.columnHeader3.Text = "Availablility";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "";
            this.columnHeader4.Text = "Virtual";
            this.columnHeader4.Width = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "System name";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "";
            this.columnHeader6.Text = "RobotWare";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "";
            this.columnHeader7.Text = "Controller Name";
            this.columnHeader7.Width = 143;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 441);
            this.Controls.Add(this.gbxControllerSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxControllerSelected.ResumeLayout(false);
            this.gbxControllerSelected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxControllerSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnProduction1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

