using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Coffee_Shop
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            public bool AddCustomer(Customer cust)
         {
            try
            {
                MySqlConnection con =  new MySqlConnection("Server=localhost;database=healthdb;uid=root;password=");
                con.Open();
                string sql = @"INSERT into customer(cust_id, cust_name, cust_contact, cust_add)
                        VALUES (@id, @name, @contact, @cust_add)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("id", cust.txt_cid.Text);
                cmd.Parameters.AddWithValue("name", cust.txt_cname.Text);
                cmd.Parameters.AddWithValue("contact", cust.txt_cno.Text);
                cmd.Parameters.AddWithValue("cust_add", cust.txt_add.Text);
              


                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception)
                {

                    throw;
                }
            }
    

        private void btn_edit_Click(object sender, EventArgs e)
        {
            public bool EditCustomer(Customer cust)
             {
                try
                {
                     MySqlConnection con =  new MySqlConnection("Server=localhost;database=healthdb;uid=root;password=");
                    con.Open();
                    string sql = @"UPDATE customer SET cust_id=@id,  cust_name= @name, cust_contact=@contact, cust_add=@cust_add,
                                     WHERE cust_id)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("id", cust.txt_cid.Text);
                    cmd.Parameters.AddWithValue("name", cust.txt_cname.Text);
                    cmd.Parameters.AddWithValue("contact",cust.txt_cno.Text);
                    cmd.Parameters.AddWithValue("cust_add",cust.txt_add.Text);
               

                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                catch (Exception)
                {

                    throw;
                }
            }

        private void btn_delete_Click(object sender, EventArgs e)
        {
         public bool DeleteCustomer(Customer cust)
             {
                try
                {
                     MySqlConnection con =  new MySqlConnection("Server=localhost;database=healthdb;uid=root;password=");
                    con.Open();
                    string sql = @"DELETE from custom WHERE cust_id)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                     cmd.Parameters.AddWithValue("id", cust.txt_cid.Text);
                    
               

                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                catch (Exception)
                {

                    throw;
                }
            }
    

        private void btn_search_Click(object sender, EventArgs e)
        {
             public void SearchByKeyword(string keyword)
        {
            try
            {
                MySqlConnection con =  new MySqlConnection("Server=localhost;database=healthdb;uid=root;password=");
                con.Open();
                string sql = @"SELECT 
                                       cust_id, cust_name, cust_contact, cust_add
                                      FROM
                                        customer
                                      WHERE cust_id =@keyword";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("keyword", keyword+"%");

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "customer");
               dgv_customer.DataSource = ds.Tables["customer"];
                con.Close();
            }



            catch (Exception)
            {

                throw;
            }

             }
    }


         private void FormCustomer_load(object sender, EventArgs e)
        {
            GetUserData();
        }

        public void GetUserData()
        {
            try
            {   
                MySqlConnection con =  new MySqlConnection("Server=localhost;database=healthdb;uid=root;password=");
                con.Open();
                string sql = "SELECT  cust_id, cust_name, cust_contact, cust_add FROM customer";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("customer");
                sda.Fill(dt);

                dgv_customer.DataSource = dt;


                con.Close();

            }
            catch (Exception)
            {
                throw;
            }

    }
   
    }
}
    
    

