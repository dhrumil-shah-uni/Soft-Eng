namespace Together_Culture
{
    partial class Titlesplash
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
            titleSplashScreen1 = new TitleSplashScreen();
            SuspendLayout();
            // 
            // titleSplashScreen1
            // 
            titleSplashScreen1.BackColor = Color.Crimson;
            titleSplashScreen1.Dock = DockStyle.Fill;
            titleSplashScreen1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleSplashScreen1.ForeColor = Color.Snow;
            titleSplashScreen1.Location = new Point(0, 0);
            titleSplashScreen1.Margin = new Padding(0);
            titleSplashScreen1.Name = "titleSplashScreen1";
            titleSplashScreen1.Size = new Size(940, 620);
            titleSplashScreen1.TabIndex = 0;
            // 
            // Titlesplash
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Crimson;
            ClientSize = new Size(940, 620);
            ControlBox = false;
            Controls.Add(titleSplashScreen1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Titlesplash";
            Text = "Titlesplash";
            Load += Titlesplash_on_Load;
            ResumeLayout(false);
        }

        #endregion

        private TitleSplashScreen titleSplashScreen1;
    }
}