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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
      
         public user LoginCheck(string user_id, string password)
        {

            user user1 = null;
            try 
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;database=healthdb;uid=root;password=");
                con.Open();
                string sql = @"SELECT user_id, password from 
                user WHERE user_id= @user_id AND password=@password;";

                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("user_id",user_id);// bind para
                cmd.Parameters.AddWithValue("password", password);//bind para
                MySqlDataReader reader= cmd.ExecuteReader();//it will observe the data
                
                if (reader.HasRows){//if check they have any rows
                while (reader.Read())// read the row
                {
                 user1= new user();
                 user1.User_id = reader.GetString("user_id");
                 user1.Password=reader.GetString(" password");
           
                
                }
              }

                con.Close();
                return user1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw; //it gives understand about error
            }
            System.Data.DataTable dt = new System.Data.DataTable();
       
            try
            {
                Session["Privillage"] = dt.Rows[0][0].ToString();

            }
            catch (IndexOutOfRangeException ex)
            {

                throw;
            }
            
            
        }
        
        private void btn_submit_Click(object sender, EventArgs e)
        {
             user user=  LoginCheck(txt_user_id.Text, txt_password.Text);
            if (user == null){
            MessageBox.Show("Authontication error, Try again!");
            }
            else{
                MessageBox.Show("Welcome");
                Response.redirect("main.aspx");
            }
         
           
                }
    }
}
