namespace Coffee_Shop
{
    partial class branch
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtr_bid = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_bname = new System.Windows.Forms.TextBox();
            this.prod_name = new System.Windows.Forms.Label();
            this.prod_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_view);
            this.groupBox1.Controls.Add(this.btn_home);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dgv_inventory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(713, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(315, 248);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
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
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(315, 199);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 31);
            this.btn_view.TabIndex = 16;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
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
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Location = new System.Drawing.Point(10, 111);
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
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "BRANCHES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtr_bid);
            this.groupBox2.Controls.Add(this.btn_ok);
            this.groupBox2.Controls.Add(this.txt_bname);
            this.groupBox2.Controls.Add(this.prod_name);
            this.groupBox2.Controls.Add(this.prod_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(409, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 279);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txtr_bid
            // 
            this.txtr_bid.Location = new System.Drawing.Point(148, 81);
            this.txtr_bid.Name = "txtr_bid";
            this.txtr_bid.Size = new System.Drawing.Size(100, 20);
            this.txtr_bid.TabIndex = 22;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(93, 160);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 19;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(148, 50);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(100, 20);
            this.txt_bname.TabIndex = 6;
            // 
            // prod_name
            // 
            this.prod_name.AutoSize = true;
            this.prod_name.Location = new System.Drawing.Point(27, 50);
            this.prod_name.Name = "prod_name";
            this.prod_name.Size = new System.Drawing.Size(72, 13);
            this.prod_name.TabIndex = 5;
            this.prod_name.Text = "Branch Name";
            // 
            // prod_id
            // 
            this.prod_id.AutoSize = true;
            this.prod_id.Location = new System.Drawing.Point(27, 81);
            this.prod_id.Name = "prod_id";
            this.prod_id.Size = new System.Drawing.Size(55, 13);
            this.prod_id.TabIndex = 1;
            this.prod_id.Text = "Branch ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Details";
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
            // branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 422);
            this.Controls.Add(this.groupBox1);
            this.Name = "branch";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.PictureBox btn_home;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtr_bid;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_bname;
        private System.Windows.Forms.Label prod_name;
        private System.Windows.Forms.Label prod_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}