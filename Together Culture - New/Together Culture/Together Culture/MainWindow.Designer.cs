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
            panel1 = new Panel();
            user_Home1 = new User_Home();
            FoundationPanel = new Panel();
            MainGrid.SuspendLayout();
            panel1.SuspendLayout();
            FoundationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainGrid
            // 
            MainGrid.BackColor = Color.Crimson;
            resources.ApplyResources(MainGrid, "MainGrid");
            MainGrid.Controls.Add(Title, 0, 0);
            MainGrid.Controls.Add(panel1, 1, 1);
            MainGrid.Name = "MainGrid";
            // 
            // Title
            // 
            resources.ApplyResources(Title, "Title");
            Title.AccessibleRole = AccessibleRole.TitleBar;
            Title.BackColor = Color.Crimson;
            Title.FlatStyle = FlatStyle.Flat;
            Title.ForeColor = Color.Snow;
            Title.Name = "Title";
            // 
            // panel1
            // 
            panel1.Controls.Add(user_Home1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // user_Home1
            // 
            resources.ApplyResources(user_Home1, "user_Home1");
            user_Home1.Name = "user_Home1";
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
            BackColor = Color.Crimson;
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
            panel1.ResumeLayout(false);
            FoundationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainGrid;
        private Label Title;
        private Panel FoundationPanel;
        private Panel panel1;
        private User_Home user_Home1;
    }
}
