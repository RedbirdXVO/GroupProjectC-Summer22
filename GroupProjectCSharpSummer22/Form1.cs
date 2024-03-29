using System.Data;

namespace GroupProjectCSharpSummer22
{
    public partial class Form1 : Form
    {
        DataTable table;
        List<MaterialEstimate> MaterialEstimateListField = new List<MaterialEstimate>();
        public Form1()
        {
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
            {
                if (!string.IsNullOrEmpty(MateTxt.Text) && !string.IsNullOrEmpty(SizeTxt.Text) && !string.IsNullOrEmpty(ItemTxt.Text) && !string.IsNullOrEmpty(QuantTxt.Text) && !string.IsNullOrEmpty(UnitTxt.Text) && !string.IsNullOrEmpty(CateTxt.Text))
                {
                    var materielEstimate = new MaterialEstimate(ItemTxt.Text.ToString(), MateTxt.Text.ToString(), SizeTxt.Text.ToString(), Convert.ToDouble(QuantTxt.Text), Convert.ToDouble(UnitTxt.Text), NotesTxt.Text.ToString(), CateTxt.Text.ToString());
                    MaterialEstimateListField.Add(materielEstimate);
                    var newRow = table.Rows.Add();
                    newRow["Category"] = materielEstimate.Category;
                    newRow["Item"] = materielEstimate.Item;
                    newRow["Material"] = materielEstimate.Material;
                    newRow["Size Description"] = materielEstimate.MaterialSize;
                    newRow["Quantity"] = materielEstimate.Quantity;
                    newRow["Unit Cost"] = materielEstimate.UnitCost;
                    newRow["Cost"] = materielEstimate.UnitCost;
                    newRow["Notes"] = materielEstimate.Note;

                }
                else
                {
                    MessageBox.Show("All inputs besides 'Notes' must be filled.");
                }
            }
            //Calculate();
        }
        /*private void Calculate()
        {
            foreach (var row in table.Rows)        
        }*/

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
            ItemTxt.Clear();
            MateTxt.Clear();
            SizeTxt.Clear();
            QuantTxt.Clear();
            UnitTxt.Clear();
            NotesTxt.Clear();
            CateTxt.Clear();
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
            table = new DataTable();
            table.Columns.Add("Category", typeof(String));
            table.Columns.Add("Item", typeof(String));
            table.Columns.Add("Material", typeof(String));
            table.Columns.Add("Size Description", typeof(String));
            table.Columns.Add("Quantity", typeof(Double));
            table.Columns.Add("Unit Cost", typeof(Double));
            table.Columns.Add("Cost", typeof(Double));
            table.Columns.Add("Notes", typeof(String));

            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
