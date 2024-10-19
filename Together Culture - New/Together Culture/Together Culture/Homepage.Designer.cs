namespace Together_Culture
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            MainGrid = new TableLayoutPanel();
            Title = new Label();
            FoundationPanel = new Panel();
            MainGrid.SuspendLayout();
            FoundationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainGrid
            // 
            MainGrid.BackColor = Color.FromArgb(27, 27, 27);
            resources.ApplyResources(MainGrid, "MainGrid");
            MainGrid.Controls.Add(Title, 0, 0);
            MainGrid.Name = "MainGrid";
            // 
            // Title
            // 
            Title.BackColor = Color.FromArgb(249, 249, 243);
            resources.ApplyResources(Title, "Title");
            Title.FlatStyle = FlatStyle.Flat;
            Title.ForeColor = Color.FromArgb(214, 26, 60);
            Title.Name = "Title";
            // 
            // FoundationPanel
            // 
            resources.ApplyResources(FoundationPanel, "FoundationPanel");
            FoundationPanel.Controls.Add(MainGrid);
            FoundationPanel.Name = "FoundationPanel";
            // 
            // MainWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(27, 27, 27);
            resources.ApplyResources(this, "$this");
            ControlBox = false;
            Controls.Add(FoundationPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Shown += MainWindow_Shown;
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            MainGrid.ResumeLayout(false);
            FoundationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainGrid;
        private Label Title;
        private Panel FoundationPanel;
    }
}
