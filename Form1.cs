using System.Data;

namespace Dictionary
{
    public partial class Form1 : Form
    {

        public Dictionary d1 = new Dictionary(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + @"dicDB.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdata();
        }

        void showdata(string s = null)
        {
            dataGridView1.DataSource = d1.returnrec(s);
            dataGridView1.Columns[0].Width = dataGridView1.Width;
            btnedit.Enabled = dataGridView1.RowCount > 0; 

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    txttranslate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                }

            }
            catch { }

        }

        private void txtenglishword_TextChanged(object sender, EventArgs e)
        {
            showdata(txtenglishword.Text);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            frmedit f1 = new frmedit(this);
            f1.ShowDialog();
            showdata();
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
        }

        public string getenglishword()
        {
            return (dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
        public string getfarsiword()
        {
            return (dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }
    }
}