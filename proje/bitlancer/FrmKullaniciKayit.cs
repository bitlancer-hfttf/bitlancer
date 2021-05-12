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


        
       
        private void logup_button_Click(object sender, EventArgs e)
        {
           

            MySqlCommand command = new MySqlCommand("insert into users(user_full_name,user_name,user_password,user_address,user_mail,user_tc,user_tel,user_type_id) " +
                "values ('" + fullname_textbox.Text + "','" + username_textbox.Text + "','" + userpassword_textbox.Text + "','" + address_richtextbox.Text + "','" + email_textbox.Text + "','" + tc_textbox.Text + "','" + mskTel.Text + "','"+6+"')",SingletonDB.GetInstance.Connection());

            command.ExecuteNonQuery();
            SingletonDB.GetInstance.Connection().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir.");
            
        }
    }
}
