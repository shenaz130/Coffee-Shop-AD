namespace Coffee_Shop
{
    partial class Customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cid = new System.Windows.Forms.TextBox();
            this.txt_cno = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.cust_name = new System.Windows.Forms.Label();
            this.cust_cno = new System.Windows.Forms.Label();
            this.cust_add = new System.Windows.Forms.Label();
            this.cust_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_home);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dgv_customer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(713, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(33, 88);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 21);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(113, 88);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(126, 20);
            this.txt_search.TabIndex = 23;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(315, 199);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(315, 151);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 31);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_home
            // 
            this.btn_home.Image = global::Coffee_Shop.Properties.Resources.website_home_button1;
            this.btn_home.Location = new System.Drawing.Point(602, 11);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(55, 37);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 15;
            this.btn_home.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(315, 99);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 31);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_customer
            // 
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Location = new System.Drawing.Point(9, 114);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.Size = new System.Drawing.Size(285, 286);
            this.dgv_customer.TabIndex = 11;
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customers  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cid);
            this.groupBox2.Controls.Add(this.txt_cno);
            this.groupBox2.Controls.Add(this.txt_add);
            this.groupBox2.Controls.Add(this.btn_ok);
            this.groupBox2.Controls.Add(this.txt_cname);
            this.groupBox2.Controls.Add(this.cust_name);
            this.groupBox2.Controls.Add(this.cust_cno);
            this.groupBox2.Controls.Add(this.cust_add);
            this.groupBox2.Controls.Add(this.cust_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(409, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 279);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txt_cid
            // 
            this.txt_cid.Location = new System.Drawing.Point(148, 53);
            this.txt_cid.Name = "txt_cid";
            this.txt_cid.Size = new System.Drawing.Size(100, 20);
            this.txt_cid.TabIndex = 22;
            // 
            // txt_cno
            // 
            this.txt_cno.Location = new System.Drawing.Point(148, 111);
            this.txt_cno.Name = "txt_cno";
            this.txt_cno.Size = new System.Drawing.Size(100, 20);
            this.txt_cno.TabIndex = 21;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(148, 138);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(100, 20);
            this.txt_add.TabIndex = 20;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(116, 200);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 19;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(148, 81);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(100, 20);
            this.txt_cname.TabIndex = 6;
            // 
            // cust_name
            // 
            this.cust_name.AutoSize = true;
            this.cust_name.Location = new System.Drawing.Point(27, 84);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(82, 13);
            this.cust_name.TabIndex = 5;
            this.cust_name.Text = "Customer Name";
            // 
            // cust_cno
            // 
            this.cust_cno.AutoSize = true;
            this.cust_cno.Location = new System.Drawing.Point(27, 111);
            this.cust_cno.Name = "cust_cno";
            this.cust_cno.Size = new System.Drawing.Size(61, 13);
            this.cust_cno.TabIndex = 4;
            this.cust_cno.Text = "Contact No";
            // 
            // cust_add
            // 
            this.cust_add.AutoSize = true;
            this.cust_add.Location = new System.Drawing.Point(27, 141);
            this.cust_add.Name = "cust_add";
            this.cust_add.Size = new System.Drawing.Size(45, 13);
            this.cust_add.TabIndex = 3;
            this.cust_add.Text = "Address";
            // 
            // cust_id
            // 
            this.cust_id.AutoSize = true;
            this.cust_id.Location = new System.Drawing.Point(27, 56);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(65, 13);
            this.cust_id.TabIndex = 1;
            this.cust_id.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "William\'s Coffee Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee_Shop.Properties.Resources.im_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 426);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customer";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.PictureBox btn_home;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cid;
        private System.Windows.Forms.TextBox txt_cno;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.Label cust_name;
        private System.Windows.Forms.Label cust_cno;
        private System.Windows.Forms.Label cust_add;
        private System.Windows.Forms.Label cust_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}