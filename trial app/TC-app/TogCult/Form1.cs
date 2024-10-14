namespace TogCult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form1 form = new Form1();
            if (e.ClickedItem.AccessibleName.Equals("fuvh"))
            {
                form.textBox1.Text = "fdfd";
            }
            else
            {
                form.textBox1.Text = "dsfls";
            }
        }
    }
}
