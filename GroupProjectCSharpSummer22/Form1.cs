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
                    var materielEstimate = new MaterialEstimate(ItemTxt.Text.ToString(), MateTxt.Text.ToString(), SizeTxt.Text.ToString(), Convert.ToInt32(QuantTxt.Text), Convert.ToDouble(UnitTxt.Text), NotesTxt.Text.ToString(), CateTxt.Text.ToString());
                    MaterialEstimateListField.Add(materielEstimate);
                    var newRow = table.Rows.Add();
                    newRow["Category"] = materielEstimate.Category;
                    newRow["Item"] = materielEstimate.Item;
                    newRow["Material"] = materielEstimate.Material;
                    newRow["Size Description"] = materielEstimate.MaterialSize;
                    newRow["Quantity"] = materielEstimate.Quantity;
                    newRow["Unit Cost"] = materielEstimate.UnitCost.ToString("C");
                    newRow["Cost"] = materielEstimate.Cost.ToString("C");
                    newRow["Notes"] = materielEstimate.Note;
                    Calculate();
                }
                else
                {
                    MessageBox.Show("All inputs besides 'Notes' must be filled.");
                }
            }

        }
        private void Calculate()
        {
            var totalCost = 0.00;
            foreach (var row in MaterialEstimateListField)
            {
                totalCost += row.Cost;
            }
            TotalTxt.Text = totalCost.ToString("C");
        }

        private void TotalTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
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
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("Unit Cost", typeof(string));
            table.Columns.Add("Cost", typeof(string));
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

        private void QuantTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void UnitTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
/*private void UnitTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void QuantTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        } */