namespace GroupProjectCSharpSummer22
{
    class MaterialEstimate
    {
        public string Category { get; set; }
        public string Item { get; set; }
        public string Materiel { get; set; }
        public string MaterielSize { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double UnitCost { get; set; }
        public double Cost { get; set; }
        public string Note { get; set; }
        MaterialEstimate(string item, string materiel, string materielSize, string size, string description, double quantity, double unitCost, string note, string category = "")
        {
            Category = category;
            Item = item;
            Materiel = materiel;
            MaterielSize = materielSize;
            Description = description;
            Quantity = quantity;
            UnitCost = unitCost;
            Cost = quantity * unitCost;
            Note = note;
        }
    }
}