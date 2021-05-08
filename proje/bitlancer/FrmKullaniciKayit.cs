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
namespace bitlancer
{
    public partial class FrmKullaniciKayit : Form
    {
        public FrmKullaniciKayit()
        {
            InitializeComponent();
        }
        
        
            MySqlConnection connection = new MySqlConnection("server=localhost;Database=bitlancer;user=root;pwd=;");
            
       
        private void logup_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("insert into users(user_full_name,user_name,user_password,user_address,user_mail,user_tc,user_tel,user_type_id) " +
                "values ('" + fullname_textbox.Text + "','" + username_textbox.Text + "','" + userpassword_textbox.Text + "','" + address_richtextbox.Text + "','" + email_textbox.Text + "','" + tc_textbox.Text + "','" + mskTel.Text + "','"+6+"')", connection);
            command.ExecuteNonQuery();
            
            MessageBox.Show("Kaydınız Gerçekleşmiştir.");
            connection.Close();
        }
    }
}
