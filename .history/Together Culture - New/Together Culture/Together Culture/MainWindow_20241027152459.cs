using System.Runtime.InteropServices;
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

        private Point mouseLocation;

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



        private void MainWindow_Shown(object sender, EventArgs e)
        {
            //this.Hide();
            Titlesplash splashScreen = new Titlesplash();
            //this.Hide();
            splashScreen.Location = this.Location;
            splashScreen.Show();
            this.Hide();
            Timer aftersplash = new Timer();
            aftersplash.Interval = 2000;
            aftersplash.Tick += (source, e) => { this.Show(); };
            aftersplash.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
