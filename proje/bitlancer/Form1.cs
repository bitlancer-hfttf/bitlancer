using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitlancer
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text!=""&&userpassword_textbox.Text!="")
            {
                int currentUser = SingletonDB.GetInstance.loginCheck(username_textbox.Text, userpassword_textbox.Text, "personal_users where user_personal_type=1");
                if (currentUser==0)
                {
                    currentUser = SingletonDB.GetInstance.loginCheck(username_textbox.Text,userpassword_textbox.Text,"users");
                }
                if (currentUser!=0)
                {
                    MessageBox.Show(currentUser.ToString());
                }
            }
        }
    }
}
