﻿namespace GroupProjectCSharpSummer22
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
            this.CateTxt = new System.Windows.Forms.TextBox();
            this.ItemTxt = new System.Windows.Forms.TextBox();
            this.MateTxt = new System.Windows.Forms.TextBox();
            this.SizeTxt = new System.Windows.Forms.TextBox();
            this.QuantTxt = new System.Windows.Forms.TextBox();
            this.UnitTxt = new System.Windows.Forms.TextBox();
            this.NotesTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.label1.Location = new System.Drawing.Point(109, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Material:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Size Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unit Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notes:";
            // 
            // CateTxt
            // 
            this.CateTxt.Location = new System.Drawing.Point(173, 424);
            this.CateTxt.Name = "CateTxt";
            this.CateTxt.Size = new System.Drawing.Size(250, 23);
            this.CateTxt.TabIndex = 19;
            // 
            // ItemTxt
            // 
            this.ItemTxt.Location = new System.Drawing.Point(173, 457);
            this.ItemTxt.Name = "ItemTxt";
            this.ItemTxt.Size = new System.Drawing.Size(250, 23);
            this.ItemTxt.TabIndex = 20;
            // 
            // MateTxt
            // 
            this.MateTxt.Location = new System.Drawing.Point(173, 491);
            this.MateTxt.Name = "MateTxt";
            this.MateTxt.Size = new System.Drawing.Size(250, 23);
            this.MateTxt.TabIndex = 21;
            // 
            // SizeTxt
            // 
            this.SizeTxt.Location = new System.Drawing.Point(173, 526);
            this.SizeTxt.Name = "SizeTxt";
            this.SizeTxt.Size = new System.Drawing.Size(250, 23);
            this.SizeTxt.TabIndex = 22;
            // 
            // QuantTxt
            // 
            this.QuantTxt.Location = new System.Drawing.Point(673, 429);
            this.QuantTxt.Name = "QuantTxt";
            this.QuantTxt.Size = new System.Drawing.Size(145, 23);
            this.QuantTxt.TabIndex = 23;
            // 
            // UnitTxt
            // 
            this.UnitTxt.Location = new System.Drawing.Point(673, 462);
            this.UnitTxt.Name = "UnitTxt";
            this.UnitTxt.Size = new System.Drawing.Size(145, 23);
            this.UnitTxt.TabIndex = 24;
            // 
            // NotesTxt
            // 
            this.NotesTxt.Location = new System.Drawing.Point(673, 499);
            this.NotesTxt.Multiline = true;
            this.NotesTxt.Name = "NotesTxt";
            this.NotesTxt.Size = new System.Drawing.Size(145, 74);
            this.NotesTxt.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 610);
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
    }
}