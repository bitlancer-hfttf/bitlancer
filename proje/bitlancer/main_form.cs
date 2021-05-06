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
    public partial class main_form : Form
    {
        DataTable data;
        int userID;
        public main_form(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            timer1.Start();
        }
        public void setUserToUI(User MyUser)
        {
            kullancıAdLabel.Text = MyUser.fullName;
            bakiyeLabel.Text = MyUser.money + " ₺";
            urunlerDatagrid.DataSource = MyUser.items;
        }
        public void updateVariables()
        {
            this.dataGridView1.DataSource = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

             data= SingletonDB.GetInstance.getItems();
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            updateVariables();
            setUserToUI(SingletonDB.GetInstance.getUser(userID));
        }
    }
}
