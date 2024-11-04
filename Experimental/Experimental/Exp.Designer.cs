namespace Experimental
{
    partial class Exp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btDisplay = new Button();
            testDataGridview = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)testDataGridview).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btDisplay
            // 
            btDisplay.Location = new Point(45, 152);
            btDisplay.Name = "btDisplay";
            btDisplay.Size = new Size(94, 29);
            btDisplay.TabIndex = 0;
            btDisplay.Text = "Display";
            btDisplay.UseVisualStyleBackColor = true;
            btDisplay.Click += displaybt_onClick;
            // 
            // testDataGridview
            // 
            testDataGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testDataGridview.Location = new Point(45, 250);
            testDataGridview.Name = "testDataGridview";
            testDataGridview.RowHeadersWidth = 51;
            testDataGridview.Size = new Size(300, 188);
            testDataGridview.TabIndex = 1;
            testDataGridview.CellContentClick += testDataGridview_CellContentClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(605, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Exp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(testDataGridview);
            Controls.Add(btDisplay);
            Name = "Exp";
            Text = "Experimental Form";
            ((System.ComponentModel.ISupportInitialize)testDataGridview).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btDisplay;
        private DataGridView testDataGridview;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}
