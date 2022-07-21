using System.Data;

namespace GroupProjectCSharpSummer22
{
    public partial class Form1 : Form
    {
        DataTable table;
        public int i;
        public List<MaterialEstimate> MaterialEstimateList { get; set; } //[i]
        public Form1()
        {
            var materialEstimateList = MaterialEstimateList;
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
 
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dataGridView1.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var materielEstimate = new MaterialEstimate(Item, Materiel, MaterielSize, Description, Quantity, UnitCost, Note, Category);
            MaterialEstimateList.Add(materielEstimate);
            Form1.Refresh();
        }

        private void TotalTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MaterialEstimateList;
        }
    }
}