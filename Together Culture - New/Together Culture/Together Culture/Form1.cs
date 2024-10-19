using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Together_Culture
{
    public partial class MainWindow : Form
    {
        //https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms/18822204

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
                //Rectangle window;
                //Point movement;
                

                //window = new Rectangle(MainWindow.ActiveForm.Left, MainWindow.ActiveForm.Top, MainWindow.ActiveForm.Width, MainWindow.ActiveForm.Height);

                //Rectangle maxBounds = Screen.GetBounds(window);
                Point mousePose = Control.MousePosition;
                
                

                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;


                //if ((window.Left >= maxBounds.Left &&
                //    window.Right <= maxBounds.Right &&
                //    window.Top >= maxBounds.Top &&
                //    window.Bottom <= maxBounds.Bottom))
                //{
                //    Location = mousePose;
                //}else
                //{
                    
                //}
                


            }
        }
    }
}
