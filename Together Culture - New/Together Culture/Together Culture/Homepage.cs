using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Timer = System.Windows.Forms.Timer;

namespace Together_Culture
{
    public partial class MainWindow : Form
    {
        //Credit: https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms/18822204

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Point mouseLocation;

        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }



        private async void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point mousePose = Control.MousePosition;

                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }

        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            FoundationPanel.Visible = false;
            Timer splash = new Timer();
            splash.Interval = 3000;
            
            splash.Tick += (source, e) => { FoundationPanel.Visible = true; titleSplashScreen1.Visible = false; titleSplashScreen1.Enabled = false; };
            splash.Start();

            //FoundationPanel.Visible = true;
            //titleSplashScreen1.Visible = false;
        }

        
    }
}
