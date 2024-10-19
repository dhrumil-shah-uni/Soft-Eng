namespace Together_Culture
{
    partial class UserHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            verticalScrollLayout1 = new FlowLayoutPanel();
            panel1 = new Panel();
            noticeboard_header = new Label();
            verticalScrollLayout1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // verticalScrollLayout1
            // 
            verticalScrollLayout1.Controls.Add(panel1);
            verticalScrollLayout1.Dock = DockStyle.Fill;
            verticalScrollLayout1.FlowDirection = FlowDirection.TopDown;
            verticalScrollLayout1.Location = new Point(5, 5);
            verticalScrollLayout1.Name = "verticalScrollLayout1";
            verticalScrollLayout1.Size = new Size(140, 140);
            verticalScrollLayout1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(noticeboard_header);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // noticeboard_header
            // 
            noticeboard_header.AutoSize = true;
            noticeboard_header.BackColor = Color.Transparent;
            noticeboard_header.Dock = DockStyle.Top;
            noticeboard_header.FlatStyle = FlatStyle.Flat;
            noticeboard_header.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noticeboard_header.Location = new Point(0, 0);
            noticeboard_header.Name = "noticeboard_header";
            noticeboard_header.Size = new Size(60, 25);
            noticeboard_header.TabIndex = 0;
            noticeboard_header.Text = "Pins";
            noticeboard_header.TextAlign = ContentAlignment.BottomCenter;
            // 
            // UserHome
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(verticalScrollLayout1);
            MinimumSize = new Size(150, 150);
            Name = "UserHome";
            Padding = new Padding(5);
            verticalScrollLayout1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel verticalScrollLayout1;
        private Panel panel1;
        private Label noticeboard_header;
    }
}
