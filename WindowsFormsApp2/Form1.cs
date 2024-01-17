using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2.Database;
using ToolQLTK;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = Connect.GetConnection();
        public Form1()
        {
            InitializeComponent("Form1");
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            loadForm();
            this.btnLoadKey.Visible = false;
        }

        public void loadForm()
        {
            int count = 1;
            try
            {
                conn.Open();
                string query = "SELECT * FROM accounts";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();
                    while (reader.Read())
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        DataGridViewRow row = dataGridView1.Rows[rowIndex];

                        row.Cells["ColumnSTT"].Value = count++;
                        row.Cells["ColumnName"].Value = reader["name"].ToString();
                        row.Cells["ColumnKey"].Value = reader["key1"].ToString();
                        row.Cells["ColumnIP"].Value = reader["ip"].ToString();

                        string inputTime = reader["expired_at"].ToString();
                        if (DateTime.TryParseExact(inputTime, "dd/MM/yyyy h:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDateTime))
                        {
                            row.Cells["ColumnExpiredAt"].Value = parsedDateTime.ToString("dd/MM/yyyy HH:mm:ss");
                        }

                        row.Cells["ColumnVIP"].Value = reader["vip"].ToString();
                        row.Cells["ColumnCheckBan"].Value = reader["block"].ToString();
                        checkBox1.Checked = reader["num_acc"].ToString() == "";
                        row.Cells["ColumnNumAcc"].Value = checkBox1.Checked ? "0.!.++" : reader["num_acc"].ToString();
                    }
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi sql: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                Application.Exit();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK);
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                isEditing = false;
                btnEdit.Text = "Chỉnh sửa";
                this.btnEdit.Click -= EditUser;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string columnKeyValue = row.Cells["ColumnKey"].Value.ToString();
                string columnNameValue = row.Cells["ColumnName"].Value.ToString();
                string columnTimeValue = row.Cells["ColumnExpiredAt"].Value.ToString();
                string columnNumAcc = row.Cells["ColumnNumAcc"].Value.ToString();
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                checkBox2.Checked = row.Cells["ColumnVIP"].Value.ToString() == "True";
                checkBox3.Checked = row.Cells["ColumnCheckBan"].Value.ToString() == "True";
                checkBox1.Checked = row.Cells["ColumnNumAcc"].Value.ToString() == "0.!.++";
                numericUpDown1.Value = checkBox1.Checked ? 1 : int.Parse(columnNumAcc);

                txtUser.Text = columnNameValue;
                txtUser.ReadOnly = true;
                txtKey.Text = columnKeyValue;
                txtKey.ReadOnly = true;
                dateTimePicker1.Text = columnTimeValue;
                dateTimePicker1.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;

                Form1.string_0 = columnNameValue;
                Form1.string_1 = columnKeyValue;
                Form1.keyCurrent = columnKeyValue;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ColumnVIP"].Index)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (e.Value != null && e.Value.ToString() == "True")
                {
                    cell.Style.BackColor = Color.FromArgb(124, 252, 0);
                    e.Value = "";
                }
                else
                {
                    cell.Style.BackColor = Color.WhiteSmoke;
                    e.Value = "";
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ColumnCheckBan"].Index)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (e.Value != null && e.Value.ToString() == "False")
                {
                    cell.Style.BackColor = Color.FromArgb(124, 252, 0);
                    e.Value = "";
                }
                else
                {
                    cell.Style.BackColor = Color.Red;
                    e.Value = "";
                }
            }
        }


        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            loadForm();
            txtSearchKey.Text = "";
            this.btnLoadKey.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormADD formADD = new FormADD();
            formADD.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string key = Form1.string_1;
            conn.Open();
            string query = "DELETE FROM accounts WHERE key1 = @key_column";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@key_column", key);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Đã xóa thành công User: {txtUser.Text}", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Error", "");
                }
            }
            txtUser.Text = "";
            txtUser.Text = "";
            conn.Close();
            loadForm();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                this.btnEdit.Text = "Lưu";
                this.txtUser.ReadOnly = false;
                this.txtKey.ReadOnly = false;
                this.dateTimePicker1.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                this.btnEdit.Click += EditUser;
                isEditing = true;
            }
            else
            {
                btnEdit.Text = "Chỉnh sửa";
                this.btnEdit.Click -= EditUser;
                isEditing = false;
            }
        }
        private void EditUser(object sender, EventArgs e)
        {
            if (!checkNull(txtUser.Text, txtKey.Text))
            {
                return;
            }
            string dateString = dateTimePicker1.Text;
            string formattedTime = "";
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDateTime))
            {
                formattedTime = parsedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            conn.Open();
            string query = "UPDATE accounts SET name = @name, key1 = @key, num_acc = @num_acc, vip = @check_vip, expired_at = @expried, block = @block WHERE key1 = @key1";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    command.Parameters.AddWithValue("@name", txtUser.Text);
                    command.Parameters.AddWithValue("@key", txtKey.Text);
                    command.Parameters.AddWithValue("@num_acc", checkBox1.Checked == true ? num_acc = null : num_acc = numericUpDown1.Value.ToString());
                    command.Parameters.AddWithValue("@check_vip", checkBox2.Checked == true ? checkVip = 1 : checkVip = 0);
                    command.Parameters.AddWithValue("@block", checkBox3.Checked == true ? checkBan = 1 : checkBan = 0);
                    command.Parameters.AddWithValue("@key1", Form1.keyCurrent);
                    command.Parameters.AddWithValue("@expried", formattedTime);
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Sửa thành công cho User: {txtUser.Text}", "Thông báo");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    return;
                }
            }
            txtUser.Text = "";
            txtKey.Text = "";
            loadForm();
        }
        private void btnSearchKey_Click(object sender, EventArgs e)
        {
            bool matchFound = false;
            string a = txtSearchKey.Text.Trim().ToString().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string cellValue = row.Cells["ColumnKey"].Value.ToString().ToLower();
                bool rowMatchFound = cellValue == a;
                row.Visible = rowMatchFound;
                if (rowMatchFound) matchFound = true;
            }
            if (!matchFound)
            {
                MessageBox.Show($"Không tìm thấy key: {a}", "Thông báo");
                loadForm();
                return;
            }
            this.btnLoadKey.Visible = true;
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
        }
        public string GetLocalIPAddress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();

                    foreach (UnicastIPAddressInformation ip in ipProperties.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            return ip.Address.ToString();
                        }
                    }
                }
            }
            return null; // Không tìm thấy địa chỉ IP Wi-Fi
        }
        static bool WebPageExists(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD"; // Use HEAD method to perform a lightweight request
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
        public static bool checkNull(string a, string b)
        {
            if (a == "" && b == "")
            {
                MessageBox.Show("Tên người dùng và Key không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool isEditing = false;
        public static bool i = true;
        public static string keyCurrent = "";
        public static string num_acc;
        public static int checkVip;
        public static int checkBan;
        public static string string_0 = "";
        public static string string_1 = "";
        public static string string_2 = "";
        public static string string_3 = "www.icrack.online/{0}/?key={1}";
        public static string string_4 = "Check_Key";
    }

}
