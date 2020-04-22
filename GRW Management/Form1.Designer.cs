using System;
using System.Windows.Forms;

namespace GRW_Management
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.add_sv = new System.Windows.Forms.Button();
            this.name_sv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_sv = new System.Windows.Forms.TextBox();
            this.class_sv = new System.Windows.Forms.TextBox();
            this.major_sv = new System.Windows.Forms.TextBox();
            this.search_sv = new System.Windows.Forms.TextBox();
            this.edit_sv = new System.Windows.Forms.Button();
            this.save_sv = new System.Windows.Forms.Button();
            this.delete_sv = new System.Windows.Forms.Button();
            this.cancel_sv = new System.Windows.Forms.Button();
            this.search_sv_bt = new System.Windows.Forms.Button();
            this.data_sv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(229, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GREENWICH STUDENT MANAGEMENT";
            // 
            // add_sv
            // 
            this.add_sv.Location = new System.Drawing.Point(64, 192);
            this.add_sv.Name = "add_sv";
            this.add_sv.Size = new System.Drawing.Size(75, 23);
            this.add_sv.TabIndex = 2;
            this.add_sv.Text = "Add";
            this.add_sv.UseVisualStyleBackColor = true;
            this.add_sv.Click += new System.EventHandler(this.Add_sv_Click);
            // 
            // name_sv
            // 
            this.name_sv.Location = new System.Drawing.Point(150, 81);
            this.name_sv.Name = "name_sv";
            this.name_sv.Size = new System.Drawing.Size(280, 22);
            this.name_sv.TabIndex = 3;
            this.name_sv.TextChanged += new System.EventHandler(this.Name_sv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Student:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Major:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Search Infomation:";
            // 
            // id_sv
            // 
            this.id_sv.Location = new System.Drawing.Point(150, 122);
            this.id_sv.Name = "id_sv";
            this.id_sv.Size = new System.Drawing.Size(168, 22);
            this.id_sv.TabIndex = 10;
            this.id_sv.TextChanged += new System.EventHandler(this.Id_sv_TextChanged);
            // 
            // class_sv
            // 
            this.class_sv.Location = new System.Drawing.Point(540, 81);
            this.class_sv.Name = "class_sv";
            this.class_sv.Size = new System.Drawing.Size(174, 22);
            this.class_sv.TabIndex = 12;
            this.class_sv.TextChanged += new System.EventHandler(this.Class_sv_TextChanged);
            // 
            // major_sv
            // 
            this.major_sv.Location = new System.Drawing.Point(540, 124);
            this.major_sv.Name = "major_sv";
            this.major_sv.Size = new System.Drawing.Size(173, 22);
            this.major_sv.TabIndex = 13;
            // 
            // search_sv
            // 
            this.search_sv.Location = new System.Drawing.Point(258, 269);
            this.search_sv.Name = "search_sv";
            this.search_sv.Size = new System.Drawing.Size(275, 22);
            this.search_sv.TabIndex = 16;
            // 
            // edit_sv
            // 
            this.edit_sv.Location = new System.Drawing.Point(172, 192);
            this.edit_sv.Name = "edit_sv";
            this.edit_sv.Size = new System.Drawing.Size(75, 23);
            this.edit_sv.TabIndex = 17;
            this.edit_sv.Text = "Edit";
            this.edit_sv.UseVisualStyleBackColor = true;
            this.edit_sv.Click += new System.EventHandler(this.Edit_sv_Click);
            // 
            // save_sv
            // 
            this.save_sv.Location = new System.Drawing.Point(490, 192);
            this.save_sv.Name = "save_sv";
            this.save_sv.Size = new System.Drawing.Size(75, 23);
            this.save_sv.TabIndex = 18;
            this.save_sv.Text = "Save";
            this.save_sv.UseVisualStyleBackColor = true;
            this.save_sv.Click += new System.EventHandler(this.Save_sv_Click);
            // 
            // delete_sv
            // 
            this.delete_sv.Location = new System.Drawing.Point(286, 192);
            this.delete_sv.Name = "delete_sv";
            this.delete_sv.Size = new System.Drawing.Size(75, 23);
            this.delete_sv.TabIndex = 19;
            this.delete_sv.Text = "Delete";
            this.delete_sv.UseVisualStyleBackColor = true;
            this.delete_sv.Click += new System.EventHandler(this.Delete_sv_Click);
            // 
            // cancel_sv
            // 
            this.cancel_sv.Location = new System.Drawing.Point(623, 192);
            this.cancel_sv.Name = "cancel_sv";
            this.cancel_sv.Size = new System.Drawing.Size(75, 23);
            this.cancel_sv.TabIndex = 20;
            this.cancel_sv.Text = "Cancel";
            this.cancel_sv.UseVisualStyleBackColor = true;
            // 
            // search_sv_bt
            // 
            this.search_sv_bt.Location = new System.Drawing.Point(560, 269);
            this.search_sv_bt.Name = "search_sv_bt";
            this.search_sv_bt.Size = new System.Drawing.Size(75, 23);
            this.search_sv_bt.TabIndex = 21;
            this.search_sv_bt.Text = "Search";
            this.search_sv_bt.UseVisualStyleBackColor = true;
            // 
            // data_sv
            // 
            this.data_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_sv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_sv.Location = new System.Drawing.Point(12, 309);
            this.data_sv.Name = "data_sv";
            this.data_sv.RowHeadersWidth = 51;
            this.data_sv.RowTemplate.Height = 24;
            this.data_sv.Size = new System.Drawing.Size(776, 173);
            this.data_sv.TabIndex = 22;
            this.data_sv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.data_sv.SelectionChanged += new System.EventHandler(this.Data_sv_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Idsv";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Namesv";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Class";
            this.Column3.HeaderText = "Class";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Major";
            this.Column4.HeaderText = "Major";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.data_sv);
            this.Controls.Add(this.search_sv_bt);
            this.Controls.Add(this.cancel_sv);
            this.Controls.Add(this.delete_sv);
            this.Controls.Add(this.save_sv);
            this.Controls.Add(this.edit_sv);
            this.Controls.Add(this.search_sv);
            this.Controls.Add(this.major_sv);
            this.Controls.Add(this.class_sv);
            this.Controls.Add(this.id_sv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_sv);
            this.Controls.Add(this.add_sv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GRW Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void Class_sv_TextChanged(object sender, EventArgs e)
        {
        }

        public void Id_sv_TextChanged(object sender, EventArgs e)
        {
        }

        public void Name_sv_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button add_sv;
        public System.Windows.Forms.TextBox name_sv;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox id_sv;
        public System.Windows.Forms.TextBox class_sv;
        public System.Windows.Forms.TextBox major_sv;
        public System.Windows.Forms.TextBox search_sv;
        public System.Windows.Forms.Button edit_sv;
        public System.Windows.Forms.Button save_sv;
        public System.Windows.Forms.Button delete_sv;
        public System.Windows.Forms.Button cancel_sv;
        public System.Windows.Forms.Button search_sv_bt;
        public System.Windows.Forms.DataGridView data_sv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}

