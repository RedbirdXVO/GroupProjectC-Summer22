using System.Data;

namespace GroupProjectCSharpSummer22
{
    public partial class Form1 : Form
    {
        int selectedIndex = -1;
        int isRowSelected = 0;
        DataTable table;
        //MarerialEstimateListField[i] = new MaterialEstimate;
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
            isRowSelected = 0;
            selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                MaterialEstimateListField.RemoveAt(selectedIndex);
                table.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            {
                if(isRowSelected == 1)
                {
                    if (!string.IsNullOrEmpty(MateTxt.Text) && !string.IsNullOrEmpty(SizeTxt.Text) && !string.IsNullOrEmpty(ItemTxt.Text) && !string.IsNullOrEmpty(QuantTxt.Text) && !string.IsNullOrEmpty(UnitTxt.Text) && !string.IsNullOrEmpty(CateTxt.Text))
                    {
                        table.Rows.RemoveAt(selectedIndex);
                        MaterialEstimateListField[selectedIndex].Category = CateTxt.Text;
                        MaterialEstimateListField[selectedIndex].Material = MateTxt.Text;
                        MaterialEstimateListField[selectedIndex].MaterialSize = SizeTxt.Text;
                        MaterialEstimateListField[selectedIndex].Note = NotesTxt.Text;
                        MaterialEstimateListField[selectedIndex].UnitCost = Convert.ToDouble(UnitTxt.Text);
                        MaterialEstimateListField[selectedIndex].Quantity = Convert.ToInt32(QuantTxt.Text);
                        MaterialEstimateListField[selectedIndex].Item = ItemTxt.Text;
                        DataRow change = table.NewRow();
                        change[0] = CateTxt.Text.ToString();
                        change[1] = ItemTxt.Text.ToString();
                        change[2] = MateTxt.Text.ToString();
                        change[3] = SizeTxt.Text.ToString();
                        change[4] = QuantTxt.Text.ToString();
                        change[5] = MaterialEstimateListField[selectedIndex].UnitCost.ToString("C");
                        change[6] = MaterialEstimateListField[selectedIndex].Cost.ToString("C");
                        change[7] = MaterialEstimateListField[selectedIndex].Note;
                        table.Rows.InsertAt(change, selectedIndex);
                        //table.Rows.InsertAt(selectedIndex);
                        /*table.Rows.InsertAt(MaterialEstimateListField[selectedIndex], 0) = MaterialEstimateListField[selectedIndex].Category;
                        change["Item"] = MaterialEstimateListField[selectedIndex].Item;
                        change["Material"] = MaterialEstimateListField[selectedIndex].Material;
                        change["Size Description"] = MaterialEstimateListField[selectedIndex].MaterialSize;
                        change["Quantity"] = MaterialEstimateListField[selectedIndex].Quantity;
                        change["Unit Cost"] = MaterialEstimateListField[selectedIndex].UnitCost.ToString("C");
                        change["Cost"] = MaterialEstimateListField[selectedIndex].Cost.ToString("C");
                        change["Notes"] = MaterialEstimateListField[selectedIndex].Note;
                        table.Rows.RemoveAt(selectedIndex);*/
                        //table.Rows.InsertAt(change, selectedIndex);

                        /*var materielEstimate = new MaterialEstimate(ItemTxt.Text.ToString(), MateTxt.Text.ToString(), SizeTxt.Text.ToString(), Convert.ToInt32(QuantTxt.Text), Convert.ToDouble(UnitTxt.Text), NotesTxt.Text.ToString(), CateTxt.Text.ToString());
                        MaterialEstimateListField.Add(materielEstimate);
                        var newRow = table.Rows.Add();
                        newRow["Category"] = materielEstimate.Category;
                        newRow["Item"] = ItemTxt.Text.ToString();
                        newRow["Material"] = MateTxt.Text;
                        newRow["Size Description"] = materielEstimate.MaterialSize;
                        newRow["Quantity"] = materielEstimate.Quantity;
                        newRow["Unit Cost"] = materielEstimate.UnitCost.ToString("C");
                        newRow["Cost"] = materielEstimate.Cost.ToString("C");
                        newRow["Notes"] = materielEstimate.Note;*/
                        isRowSelected = 0;
                        //var change = dataGridView1.Rows[selectedIndex];
                    }
                    else
                    {
                        MessageBox.Show("All inputs besides 'Notes' must be filled.");
                    }
                }
                /*if(x = 0)
                 {
                    var selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    var materialEstimate = MaterialEstimateListField[selectedIndex];
                    
                    */
                else
                {
                    if (!string.IsNullOrEmpty(MateTxt.Text) && !string.IsNullOrEmpty(SizeTxt.Text) && !string.IsNullOrEmpty(ItemTxt.Text) && !string.IsNullOrEmpty(QuantTxt.Text) && !string.IsNullOrEmpty(UnitTxt.Text) && !string.IsNullOrEmpty(CateTxt.Text))
                    {
                        var materielEstimate = new MaterialEstimate(ItemTxt.Text.ToString(), MateTxt.Text.ToString(), SizeTxt.Text.ToString(), Convert.ToInt32(QuantTxt.Text), Convert.ToDouble(UnitTxt.Text), NotesTxt.Text.ToString(), CateTxt.Text.ToString());
                        MaterialEstimateListField.Add(materielEstimate);
                        var newRow = table.Rows.Add();
                        newRow["Category"] = materielEstimate.Category;
                        newRow["Item"] = ItemTxt.Text.ToString();
                        newRow["Material"] = MateTxt.Text;
                        newRow["Size Description"] = materielEstimate.MaterialSize;
                        newRow["Quantity"] = materielEstimate.Quantity;
                        newRow["Unit Cost"] = materielEstimate.UnitCost.ToString("C");
                        newRow["Cost"] = materielEstimate.Cost.ToString("C");
                        newRow["Notes"] = materielEstimate.Note;
                    }
                    else
                    {
                        MessageBox.Show("All inputs besides 'Notes' must be filled.");
                    }
                }

            }

        }
        

        private void TotalTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            isRowSelected = 0;
            table.Rows.Clear();
            dataGridView1.Refresh();
            MaterialEstimateListField.RemoveRange(0, MaterialEstimateListField.Count);

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            isRowSelected = 0;
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
            isRowSelected = 0;
            var totalCost = 0.00;
            foreach (var row in MaterialEstimateListField)
            {
                totalCost += row.Cost;
            }
            TotalTxt.Text = totalCost.ToString("C");
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            isRowSelected = 1;
            selectedIndex = dataGridView1.CurrentCell.RowIndex;
            CateTxt.Text = MaterialEstimateListField[selectedIndex].Category;
            UnitTxt.Text = MaterialEstimateListField[selectedIndex].UnitCost.ToString();
            NotesTxt.Text = MaterialEstimateListField[selectedIndex].Note;
            QuantTxt.Text = MaterialEstimateListField[selectedIndex].Quantity.ToString();
            ItemTxt.Text = MaterialEstimateListField[selectedIndex].Item;
            SizeTxt.Text = MaterialEstimateListField[selectedIndex].MaterialSize;
            MateTxt.Text = MaterialEstimateListField[selectedIndex].Material;

        }
    }
}
/*private void UnitTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void QuantTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        } */