namespace Coffee_Shop
{
    partial class Inventory
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txtr_pid = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_supid = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.prod_name = new System.Windows.Forms.Label();
            this.prod_price = new System.Windows.Forms.Label();
            this.sup_id = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.prod_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_home);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgv_inventory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(713, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGreen;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(315, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(315, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(315, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Location = new System.Drawing.Point(9, 96);
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.Size = new System.Drawing.Size(285, 286);
            this.dgv_inventory.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_quantity);
            this.groupBox2.Controls.Add(this.txtr_pid);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.txt_supid);
            this.groupBox2.Controls.Add(this.btn_ok);
            this.groupBox2.Controls.Add(this.txt_pname);
            this.groupBox2.Controls.Add(this.prod_name);
            this.groupBox2.Controls.Add(this.prod_price);
            this.groupBox2.Controls.Add(this.sup_id);
            this.groupBox2.Controls.Add(this.quantity);
            this.groupBox2.Controls.Add(this.prod_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(409, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 279);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(148, 169);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 23;
            // 
            // txtr_pid
            // 
            this.txtr_pid.Location = new System.Drawing.Point(148, 81);
            this.txtr_pid.Name = "txtr_pid";
            this.txtr_pid.Size = new System.Drawing.Size(100, 20);
            this.txtr_pid.TabIndex = 22;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(148, 111);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 21;
            // 
            // txt_supid
            // 
            this.txt_supid.Location = new System.Drawing.Point(148, 138);
            this.txt_supid.Name = "txt_supid";
            this.txt_supid.Size = new System.Drawing.Size(100, 20);
            this.txt_supid.TabIndex = 20;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(84, 224);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 19;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(148, 50);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(100, 20);
            this.txt_pname.TabIndex = 6;
            // 
            // prod_name
            // 
            this.prod_name.AutoSize = true;
            this.prod_name.Location = new System.Drawing.Point(27, 50);
            this.prod_name.Name = "prod_name";
            this.prod_name.Size = new System.Drawing.Size(75, 13);
            this.prod_name.TabIndex = 5;
            this.prod_name.Text = "Product Name";
            // 
            // prod_price
            // 
            this.prod_price.AutoSize = true;
            this.prod_price.Location = new System.Drawing.Point(27, 111);
            this.prod_price.Name = "prod_price";
            this.prod_price.Size = new System.Drawing.Size(52, 13);
            this.prod_price.TabIndex = 4;
            this.prod_price.Text = "Unit price";
            // 
            // sup_id
            // 
            this.sup_id.AutoSize = true;
            this.sup_id.Location = new System.Drawing.Point(27, 141);
            this.sup_id.Name = "sup_id";
            this.sup_id.Size = new System.Drawing.Size(53, 13);
            this.sup_id.TabIndex = 3;
            this.sup_id.Text = "Supply ID";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(27, 169);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(46, 13);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "Quantity";
            // 
            // prod_id
            // 
            this.prod_id.AutoSize = true;
            this.prod_id.Location = new System.Drawing.Point(27, 81);
            this.prod_id.Name = "prod_id";
            this.prod_id.Size = new System.Drawing.Size(58, 13);
            this.prod_id.TabIndex = 1;
            this.prod_id.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Details";
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 415);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inventory";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label prod_name;
        private System.Windows.Forms.Label prod_price;
        private System.Windows.Forms.Label sup_id;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label prod_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.PictureBox btn_home;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txtr_pid;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_supid;
        private System.Windows.Forms.Button btn_ok;

    }
}