namespace GroupProjectCSharpSummer22
{
    class MaterialEstimate
    {
        public string Category { get; set; }
        public string Item { get; set; }
        public string Material { get; set; }
        public string MaterialSize { get; set; }
        public double Quantity { get; set; }
        public double UnitCost { get; set; }
        public double Cost { get; set; }
        public string Note { get; set; }
        public MaterialEstimate(string item, string material, string materialSize, double quantity, double unitCost, string note, string category)
        {
            Category = category;
            Item = item;
            Material = material;
            MaterialSize = materialSize;
            Quantity = quantity;
            UnitCost = unitCost;
            Cost = quantity * unitCost;
            Note = note;
            
        }
    }
}