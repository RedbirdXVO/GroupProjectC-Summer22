namespace GroupProjectCSharpSummer22
{
    class MaterialEstimate
    {
        public string Category { get; set; }
        public string Item { get; set; }
        public string Material { get; set; }
        public string MaterialSize { get; set; }
        public int Quantity { get; set; }
        public double UnitCost { get; set; }
        public double Cost { get; set; }
        public string Note { get; set; }
        //Class to store all the variables in the dataGridView on Form1, and allows us to call upon it to read
        public MaterialEstimate(string item, string material, string materialSize, int quantity, double unitCost, string note, string category)
        {
            Category = category;
            Item = item;
            Material = material;
            MaterialSize = materialSize;
            Quantity = quantity;
            UnitCost = unitCost;
            Cost = quantity * unitCost;
            //Cost is calculated before returned to the table
            Note = note;
        }
    }
}