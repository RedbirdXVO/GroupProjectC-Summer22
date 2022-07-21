namespace GroupProjectCSharpSummer22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CategoryCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnityCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryCln,
            this.ItemCln,
            this.MaterialCln,
            this.SizeCln,
            this.QuantityCln,
            this.UnityCln,
            this.CostCln,
            this.NotesCln});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // CategoryCln
            // 
            this.CategoryCln.HeaderText = "Category";
            this.CategoryCln.Name = "CategoryCln";
            // 
            // ItemCln
            // 
            this.ItemCln.HeaderText = "Item";
            this.ItemCln.Name = "ItemCln";
            // 
            // MaterialCln
            // 
            this.MaterialCln.HeaderText = "Material";
            this.MaterialCln.Name = "MaterialCln";
            // 
            // SizeCln
            // 
            this.SizeCln.HeaderText = "Size Descriptions";
            this.SizeCln.Name = "SizeCln";
            // 
            // QuantityCln
            // 
            this.QuantityCln.HeaderText = "Quantity";
            this.QuantityCln.Name = "QuantityCln";
            // 
            // UnityCln
            // 
            this.UnityCln.HeaderText = "Unit Cost";
            this.UnityCln.Name = "UnityCln";
            // 
            // CostCln
            // 
            this.CostCln.HeaderText = "Cost";
            this.CostCln.Name = "CostCln";
            this.CostCln.ReadOnly = true;
            // 
            // NotesCln
            // 
            this.NotesCln.HeaderText = "Notes";
            this.NotesCln.Name = "NotesCln";
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(247, 575);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 25);
            this.NewBtn.TabIndex = 3;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(364, 575);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 25);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(480, 575);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 25);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.AutoSize = true;
            this.ClearBtn.Location = new System.Drawing.Point(597, 575);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 25);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Your Total is:";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(429, 401);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(232, 23);
            this.TotalTxt.TabIndex = 8;
            this.TotalTxt.TextChanged += new System.EventHandler(this.TotalTxt_TextChanged);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(824, 579);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(90, 23);
            this.CalcBtn.TabIndex = 9;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(990, 579);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 23);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 424);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 23);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 457);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 491);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 23);
            this.textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 526);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 23);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(673, 429);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 23);
            this.textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(673, 462);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 23);
            this.textBox7.TabIndex = 24;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(673, 499);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(145, 74);
            this.textBox9.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 610);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button NewBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private Button ClearBtn;
        private TextBox textBox1;
        private TextBox TotalTxt;
        private Button CalcBtn;
        private Button ExitBtn;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CategoryCln;
        private DataGridViewTextBoxColumn ItemCln;
        private DataGridViewTextBoxColumn MaterialCln;
        private DataGridViewTextBoxColumn SizeCln;
        private DataGridViewTextBoxColumn QuantityCln;
        private DataGridViewTextBoxColumn UnityCln;
        private DataGridViewTextBoxColumn CostCln;
        private DataGridViewTextBoxColumn NotesCln;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox9;
    }
}