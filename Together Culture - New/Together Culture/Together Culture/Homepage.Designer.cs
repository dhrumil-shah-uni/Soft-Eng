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
            FoundationPanel = new Panel();
            MainGrid = new TableLayoutPanel();
            Title = new Label();
            titleSplashScreen1 = new TitleSplashScreen();
            FoundationPanel.SuspendLayout();
            MainGrid.SuspendLayout();
            SuspendLayout();
            // 
            // FoundationPanel
            // 
            resources.ApplyResources(FoundationPanel, "FoundationPanel");
            FoundationPanel.Controls.Add(MainGrid);
            FoundationPanel.Name = "FoundationPanel";
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
            // titleSplashScreen1
            // 
            titleSplashScreen1.BackColor = Color.Crimson;
            resources.ApplyResources(titleSplashScreen1, "titleSplashScreen1");
            titleSplashScreen1.ForeColor = Color.Snow;
            titleSplashScreen1.Name = "titleSplashScreen1";
            // 
            // MainWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(27, 27, 27);
            resources.ApplyResources(this, "$this");
            ControlBox = false;
            Controls.Add(titleSplashScreen1);
            Controls.Add(FoundationPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Load += MainWindow_Load;
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            FoundationPanel.ResumeLayout(false);
            MainGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel FoundationPanel;
        private TableLayoutPanel MainGrid;
        private Label Title;
        private TitleSplashScreen titleSplashScreen1;
    }
}
