using System.Windows.Forms;
namespace WindowsFormsApp2
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

        private void InitializeComponent(string v)
        {
            this.FormBorderStyle = FormBorderStyle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearchKey = new System.Windows.Forms.Button();
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpiredAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewData = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSTT,
            this.ColumnName,
            this.ColumnKey,
            this.ColumnNumAcc,
            this.ColumnIP,
            this.ColumnVIP,
            this.ColumnExpiredAt,
            this.ColumnCheckBan,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 547);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridView1_CellPainting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.btnViewData);
            this.groupBox1.Controls.Add(this.txtSearchKey);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnLoadKey);
            this.groupBox1.Controls.Add(this.btnSearchKey);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1177, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 547);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gia hạn đến : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hoặc không giới hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phiên bản VIP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "BAN";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(85, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(163, 210);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearchKey
            // 
            this.btnSearchKey.Location = new System.Drawing.Point(163, 239);
            this.btnSearchKey.Name = "btnSearchKey";
            this.btnSearchKey.Size = new System.Drawing.Size(75, 23);
            this.btnSearchKey.TabIndex = 10;
            this.btnSearchKey.Text = "Tìm kiếm";
            this.btnSearchKey.UseVisualStyleBackColor = true;
            this.btnSearchKey.Click += new System.EventHandler(this.btnSearchKey_Click);
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Location = new System.Drawing.Point(6, 268);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(232, 23);
            this.btnLoadKey.TabIndex = 11;
            this.btnLoadKey.Text = "Tải xuống tri thức III";
            this.btnLoadKey.UseVisualStyleBackColor = true;
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(223, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(87, 178);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(146, 178);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(40, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(198, 20);
            this.txtUser.TabIndex = 15;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(40, 55);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(198, 20);
            this.txtKey.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(61, 136);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(7, 241);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(153, 20);
            this.txtSearchKey.TabIndex = 19;
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.HeaderText = "ID";
            this.ColumnSTT.Name = "ColumnSTT";
            this.ColumnSTT.ReadOnly = true;
            this.ColumnSTT.Width = 32;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Tên người dùng";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 132;
            // 
            // ColumnKey
            // 
            this.ColumnKey.HeaderText = "Key Security";
            this.ColumnKey.Name = "ColumnKey";
            this.ColumnKey.ReadOnly = true;
            this.ColumnKey.Width = 369;
            // 
            // ColumnNumAcc
            // 
            this.ColumnNumAcc.HeaderText = "Số lượng";
            this.ColumnNumAcc.Name = "ColumnNumAcc";
            this.ColumnNumAcc.ReadOnly = true;
            this.ColumnNumAcc.Width = 84;
            // 
            // ColumnIP
            // 
            this.ColumnIP.HeaderText = "IPv4";
            this.ColumnIP.Name = "ColumnIP";
            this.ColumnIP.ReadOnly = true;
            this.ColumnIP.Width = 128;
            // 
            // ColumnVIP
            // 
            this.ColumnVIP.HeaderText = "VIP";
            this.ColumnVIP.Name = "ColumnVIP";
            this.ColumnVIP.ReadOnly = true;
            this.ColumnVIP.Width = 48;
            // 
            // ColumnExpiredAt
            // 
            this.ColumnExpiredAt.HeaderText = "Ngày hết hạn";
            this.ColumnExpiredAt.Name = "ColumnExpiredAt";
            this.ColumnExpiredAt.ReadOnly = true;
            this.ColumnExpiredAt.Width = 128;
            // 
            // ColumnCheckBan
            // 
            this.ColumnCheckBan.HeaderText = "Ban";
            this.ColumnCheckBan.Name = "ColumnCheckBan";
            this.ColumnCheckBan.ReadOnly = true;
            this.ColumnCheckBan.Width = 48;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Chưa nghĩ ra <3";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 186;
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(6, 297);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(232, 23);
            this.btnViewData.TabIndex = 20;
            this.btnViewData.Text = "Lấy dữ liệu từ API";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(9, 337);
            this.txtData.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(229, 20);
            this.txtData.TabIndex = 21;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1435, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản lý Key";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;    
            this.MinimizeBox = false;
            this.MaximizeBox = false;   
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLoadKey;
        private System.Windows.Forms.Button btnSearchKey;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpiredAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.TextBox txtData;
    }
}