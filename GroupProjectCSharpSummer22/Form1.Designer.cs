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
            this.NewBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.TotalText = new System.Windows.Forms.TextBox();
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
            this.CateTxt = new System.Windows.Forms.TextBox();
            this.ItemTxt = new System.Windows.Forms.TextBox();
            this.MateTxt = new System.Windows.Forms.TextBox();
            this.SizeTxt = new System.Windows.Forms.TextBox();
            this.QuantTxt = new System.Windows.Forms.TextBox();
            this.UnitTxt = new System.Windows.Forms.TextBox();
            this.NotesTxt = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1484, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewBtn.Location = new System.Drawing.Point(317, 595);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 25);
            this.NewBtn.TabIndex = 3;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaveBtn.Location = new System.Drawing.Point(492, 595);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 25);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeleteBtn.Location = new System.Drawing.Point(943, 595);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 25);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.AutoSize = true;
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearBtn.Location = new System.Drawing.Point(1130, 595);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 25);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // TotalText
            // 
            this.TotalText.BackColor = System.Drawing.Color.Salmon;
            this.TotalText.Location = new System.Drawing.Point(638, 372);
            this.TotalText.Name = "TotalText";
            this.TotalText.ReadOnly = true;
            this.TotalText.Size = new System.Drawing.Size(232, 23);
            this.TotalText.TabIndex = 7;
            this.TotalText.Text = "Your Total is:";
            // 
            // TotalTxt
            // 
            this.TotalTxt.BackColor = System.Drawing.Color.Salmon;
            this.TotalTxt.Location = new System.Drawing.Point(638, 401);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(232, 23);
            this.TotalTxt.TabIndex = 8;
            this.TotalTxt.TextChanged += new System.EventHandler(this.TotalTxt_TextChanged);
            // 
            // CalcBtn
            // 
            this.CalcBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CalcBtn.Location = new System.Drawing.Point(638, 432);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(232, 48);
            this.CalcBtn.TabIndex = 9;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = false;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitBtn.Location = new System.Drawing.Point(1396, 614);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 23);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Material:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Size Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(878, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unit Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(896, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notes:";
            // 
            // CateTxt
            // 
            this.CateTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CateTxt.Location = new System.Drawing.Point(317, 424);
            this.CateTxt.Name = "CateTxt";
            this.CateTxt.Size = new System.Drawing.Size(250, 23);
            this.CateTxt.TabIndex = 19;
            // 
            // ItemTxt
            // 
            this.ItemTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItemTxt.Location = new System.Drawing.Point(317, 453);
            this.ItemTxt.Name = "ItemTxt";
            this.ItemTxt.Size = new System.Drawing.Size(250, 23);
            this.ItemTxt.TabIndex = 20;
            // 
            // MateTxt
            // 
            this.MateTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MateTxt.Location = new System.Drawing.Point(317, 491);
            this.MateTxt.Name = "MateTxt";
            this.MateTxt.Size = new System.Drawing.Size(250, 23);
            this.MateTxt.TabIndex = 21;
            // 
            // SizeTxt
            // 
            this.SizeTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SizeTxt.Location = new System.Drawing.Point(317, 526);
            this.SizeTxt.Name = "SizeTxt";
            this.SizeTxt.Size = new System.Drawing.Size(250, 23);
            this.SizeTxt.TabIndex = 22;
            // 
            // QuantTxt
            // 
            this.QuantTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QuantTxt.Location = new System.Drawing.Point(943, 429);
            this.QuantTxt.Name = "QuantTxt";
            this.QuantTxt.Size = new System.Drawing.Size(262, 23);
            this.QuantTxt.TabIndex = 23;
            this.QuantTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantTxt_KeyPress);
            // 
            // UnitTxt
            // 
            this.UnitTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UnitTxt.Location = new System.Drawing.Point(943, 462);
            this.UnitTxt.Name = "UnitTxt";
            this.UnitTxt.Size = new System.Drawing.Size(262, 23);
            this.UnitTxt.TabIndex = 24;
            this.UnitTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitTxt_KeyPress);
            // 
            // NotesTxt
            // 
            this.NotesTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NotesTxt.Location = new System.Drawing.Point(943, 496);
            this.NotesTxt.Multiline = true;
            this.NotesTxt.Name = "NotesTxt";
            this.NotesTxt.Size = new System.Drawing.Size(262, 74);
            this.NotesTxt.TabIndex = 26;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EditBtn.Location = new System.Drawing.Point(5, 371);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 143);
            this.EditBtn.TabIndex = 27;
            this.EditBtn.Text = "Select/Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1494, 645);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NotesTxt);
            this.Controls.Add(this.UnitTxt);
            this.Controls.Add(this.QuantTxt);
            this.Controls.Add(this.SizeTxt);
            this.Controls.Add(this.MateTxt);
            this.Controls.Add(this.ItemTxt);
            this.Controls.Add(this.CateTxt);
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
            this.Controls.Add(this.TotalText);
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
        private TextBox TotalText;
        private TextBox TotalTxt;
        private Button CalcBtn;
        private Button ExitBtn;
        public DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox CateTxt;
        private TextBox ItemTxt;
        private TextBox MateTxt;
        private TextBox SizeTxt;
        private TextBox QuantTxt;
        private TextBox UnitTxt;
        private TextBox NotesTxt;
        private Button EditBtn;
    }
}