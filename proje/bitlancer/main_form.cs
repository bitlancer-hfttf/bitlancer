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
        User MyUser;
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
        public void setUserToUI()
        {
            this.dataGridView1.DataSource = data;
            kullancıAdLabel.Text = MyUser.fullName;
            switch (MyUser.userType)
            {
                case bitlancer.userTypes.basic: kullaniciTipiLabel.Text = "Temel Kullanıcı";
                    break;
                case bitlancer.userTypes.admin: kullaniciTipiLabel.Text = "Üst Düzey Kullanıcı";
                    break;
                default: kullaniciTipiLabel.Text = "Temel Kullanıcı";
                    break;
            }
            bakiyeLabel.Text = MyUser.money + " ₺";
            urunlerDatagrid.DataSource = MyUser.items;
            List<chartItemValue> chartItemList = new List<chartItemValue>();
            foreach (item item in MyUser.items)
            {
                chartItemList.Add(new chartItemValue(item.itemName,item.quantity*item.unitPrice));
            }
            graphic.DataSource = chartItemList;
            graphic.Series["Para"].XValueMember = "itemName";
            graphic.Series["Para"].YValueMembers = "val";
            graphic.DataBind();
            chartItemList.Clear();
            transferlerDatgrid.DataSource = SingletonDB.GetInstance.getItemTransfers(MyUser.id);
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
            MyUser = SingletonDB.GetInstance.getUser(userID);
            data = SingletonDB.GetInstance.getItems();
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setUserToUI();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}
