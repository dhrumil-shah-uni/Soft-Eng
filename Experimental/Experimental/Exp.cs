using System.Data;

namespace Experimental
{
    public partial class Exp : Form
    {
        public Exp()
        {
            InitializeComponent();
        }

        private void displaybt_onClick(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataSet dataSet = DBConnection.getInstanceofDBConnectionStr().GetDataSet(Constants.SELECTALL);
            testDataGridview.DataSource = dataSet.Tables[0];
        }

        private void testDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
