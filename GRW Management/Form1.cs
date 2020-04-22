using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRW_Management
{
    public partial class Form1 : Form
    {
        string flag;
        DataTable dtSV;
         int index;
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Idsv");
            dt.Columns.Add("Namesv");
            dt.Columns.Add("Class");
            dt.Columns.Add("Major");
            return dt;
        }

        public void LockControl()
        {
            add_sv.Enabled = true;
            edit_sv.Enabled = true;
            delete_sv.Enabled = true;
            save_sv.Enabled = false;
            cancel_sv.Enabled = false;

            id_sv.ReadOnly = true;
            name_sv.ReadOnly = true;
            class_sv.ReadOnly = true;
            major_sv.ReadOnly = true;

            add_sv.Focus();
        }
        public void UnlockControl()
        {
            add_sv.Enabled = false;
            edit_sv.Enabled = false;
            delete_sv.Enabled = false;
            save_sv.Enabled = true;
            cancel_sv.Enabled = true;

            id_sv.ReadOnly = false;
            name_sv.ReadOnly = false;
            class_sv.ReadOnly = false;
            major_sv.ReadOnly = false;

            id_sv.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LockControl();
            dtSV = createTable();
        }

        private void Add_sv_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";

            id_sv.Text = "";
            name_sv.Text = "";
            class_sv.Text = "";
            major_sv.Text = "";
        }

        private void Save_sv_Click(object sender, EventArgs e)
        {
            if(flag == "add")
            {
                if(checkData())
                {
                    dtSV.Rows.Add(id_sv.Text, name_sv.Text, class_sv.Text, major_sv.Text);
                    data_sv.DataSource = dtSV;
                    data_sv.RefreshEdit();
                }
                else if(flag == "edit")
                {
                    if(checkData())
                    {
                        dtSV.Rows[index][0] = id_sv.Text;
                        dtSV.Rows[index][1] = name_sv.Text;
                        dtSV.Rows[index][2] = class_sv.Text;
                        dtSV.Rows[index][3] = major_sv.Text;
                        data_sv.DataSource = dtSV;
                        data_sv.RefreshEdit();
                    }
                }
            }
            LockControl();
        }
        public bool checkData()
        {
            if(string.IsNullOrWhiteSpace(id_sv.Text))
            {
                MessageBox.Show("You haven't inputed ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id_sv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(name_sv.Text))
            {
                MessageBox.Show("You haven't inputed Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name_sv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(class_sv.Text))
            {
                MessageBox.Show("You haven't inputed Class", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class_sv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(major_sv.Text))
            {
                MessageBox.Show("You haven't inputed Major", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                major_sv.Focus();
                return false;
            }
            return true;
        }
        private void Edit_sv_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "edit";
        }

        private void Data_sv_SelectionChanged(object sender, EventArgs e)
        {
            index = data_sv.CurrentCell.RowIndex;
            DataTable dt = (DataTable)data_sv.DataSource;
            if(dt.Rows.Count > 0)
            {
                id_sv.Text = data_sv.Rows[index].Cells[0].Value.ToString();
                name_sv.Text = data_sv.Rows[index].Cells[1].Value.ToString();
                class_sv.Text = data_sv.Rows[index].Cells[2].Value.ToString();
                major_sv.Text = data_sv.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void Delete_sv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this information?", "Warm up", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes );
            {
                dtSV.Rows.RemoveAt(index);
                data_sv.DataSource = dtSV;
                data_sv.RefreshEdit();
            }
        }
    }   
}
