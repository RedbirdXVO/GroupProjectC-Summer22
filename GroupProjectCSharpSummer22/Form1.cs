using System.Data;

namespace GroupProjectCSharpSummer22
{
    public partial class Form1 : Form
    {
        int selectedIndex = -1;
        //Set to an index of -1, variable is used to define the index of a row that is selected
        int isRowSelected = 0;
        //Used for the Select/Edit button, determines if the select button is pressed
        DataTable table;
        List<MaterialEstimate> MaterialEstimateListField = new List<MaterialEstimate>();
        //Sets the dataTable function for the datagridview, and initiates a list for the MaterialEstimate Class
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            TotalText.Visible = false;
            TotalTxt.Visible = false;
            isRowSelected = 0;
            //Resets isRowSelected whenever a button besides Select/Edit is pressed, so no mistakes happen
            selectedIndex = dataGridView1.CurrentCell.RowIndex;
            //sets the Row Index of the selected/highlighted row

            if (selectedIndex > -1)
            {
                MaterialEstimateListField.RemoveAt(selectedIndex);
                table.Rows.RemoveAt(selectedIndex);
                //Removes the row from the dataGridView at the specified index
                dataGridView1.Refresh();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            {
                TotalText.Visible = false;
                TotalTxt.Visible = false;
                if (isRowSelected == 1)
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
                        //If the Select/Edit button was pressed, this part of the method will replace the current row in both the List and DataGrid to the new inputs

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
                        //utilizes a DataRow function to change the selected row's inputs/variables

                        isRowSelected = 0;
                    }
                    else
                    {
                        MessageBox.Show("All inputs besides 'Notes' must be filled.");
                        //displays if some inputs were left out
                    }
                }

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
                        //Creates a new variable for the MaterialEstimate Class, and adds the new variables from the inputs to both the class list and the datagrid
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
            TotalText.Visible = false;
            TotalTxt.Visible = false;
            isRowSelected = 0;
            table.Rows.Clear();
            dataGridView1.Refresh();
            MaterialEstimateListField.RemoveRange(0, MaterialEstimateListField.Count);
            ItemTxt.Clear();
            MateTxt.Clear();
            SizeTxt.Clear();
            QuantTxt.Clear();
            UnitTxt.Clear();
            NotesTxt.Clear();
            CateTxt.Clear();
            //Method to clear all textboxes and all data from the List for MaterialEstimate and the data in the datagrid when the clear button is clicked

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TotalText.Visible = false;
            TotalTxt.Visible = false;
            isRowSelected = 0;
            ItemTxt.Clear();
            MateTxt.Clear();
            SizeTxt.Clear();
            QuantTxt.Clear();
            UnitTxt.Clear();
            NotesTxt.Clear();
            CateTxt.Clear();
            //Clears the textboxes so that a new row can be added when NewBtn is clicked
            
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            TotalText.Visible = true;
            TotalTxt.Visible = true;
            isRowSelected = 0;
            var totalCost = 0.00;
            foreach (var row in MaterialEstimateListField)
            {
                totalCost += row.Cost;
            }
            TotalTxt.Text = totalCost.ToString("C");
            //Calculates and displays the total cost for all the rows in the datagrid and MaterialEstimate List
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //Method to close the application when Exit is clicked
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
            //assigns the columns and the dataTable to DataGridView1

            TotalText.Visible = false;
            TotalTxt.Visible = false;
            //Hides the calculation boxes so that the total isn't displayed until calculate is pressed
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
            //makes it so only numbers can be entered into the Quantity TextBox

        }

        private void UnitTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allows one decimal point to be used, thus allowing for double inputs for the UnitCost
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            TotalText.Visible = false;
            TotalTxt.Visible = false;
            isRowSelected = 1;
            selectedIndex = dataGridView1.CurrentCell.RowIndex;
            CateTxt.Text = MaterialEstimateListField[selectedIndex].Category;
            UnitTxt.Text = MaterialEstimateListField[selectedIndex].UnitCost.ToString();
            NotesTxt.Text = MaterialEstimateListField[selectedIndex].Note;
            QuantTxt.Text = MaterialEstimateListField[selectedIndex].Quantity.ToString();
            ItemTxt.Text = MaterialEstimateListField[selectedIndex].Item;
            SizeTxt.Text = MaterialEstimateListField[selectedIndex].MaterialSize;
            MateTxt.Text = MaterialEstimateListField[selectedIndex].Material;
            //When Select/Edit is clicked, changes the isRowSelected variable so the save button works properly, and loads all of the data from the row's index in both the list and the table

        }
    }
}
