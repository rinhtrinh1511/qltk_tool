using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using WindowsFormsApp2.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ToolQLTK
{
    public partial class FormADD : Form
    {
        MySqlConnection conn = Connect.GetConnection();
        public FormADD()
        {
            InitializeComponent();
            this.Load += FormADD_Load;
        }

        private void FormADD_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {     
            string dateString = dateTimePicker1.Text;
            DateTime date = DateTime.Parse(dateString);
            DateTime now = DateTime.Now;
            DateTime resultTime = new DateTime(date.Year, date.Month, date.Day, now.Hour, now.Minute, now.Second);
            if (!Form1.checkNull(txtUser.Text, txtKey.Text))
            {
                return;
            }
            try
            {
                conn.Open();
                string query = "INSERT INTO accounts (name, key1, num_acc, vip, expired_at) VALUES (@name, @key, @num_acc, @vip, @expired_at)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", txtUser.Text);
                    command.Parameters.AddWithValue("@key", txtKey.Text);
                    command.Parameters.AddWithValue("@num_acc", checkBox1.Checked == true ? Form1.num_acc = null : numericUpDown1.Value.ToString());
                    command.Parameters.AddWithValue("@vip", checkBox2.Checked == true ? Form1.checkVip = 1 : Form1.checkVip = 0);
                    command.Parameters.AddWithValue("@expired_at", resultTime);
                    int rowsInserted = command.ExecuteNonQuery();
                    MessageBox.Show($"Đã thêm thành công người dùng: {txtUser.Text}\nKey: {txtKey.Text}", "Thông báo");
                }
                txtUser.Text = "";
                txtKey.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                conn.Close();
                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (form1 != null)
                {
                    form1.loadForm();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi MySQL: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
            
        }

    }
}
