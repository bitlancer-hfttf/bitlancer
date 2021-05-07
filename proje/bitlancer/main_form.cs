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
        DataTable itemData,lastOrdersData;
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
            try
            {
                dataGridView1.DataSource = itemData;
                lastOrdersDatagrid.DataSource = lastOrdersData;
                foreach (DataGridViewRow row in lastOrdersDatagrid.Rows)
                {
                    if (row.Cells[1].Value.ToString()=="ALIM")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                    
                kullancıAdLabel.Text = MyUser.fullName;
                switch (MyUser.userType)
                {
                    case bitlancer.userTypes.basic:
                        kullaniciTipiLabel.Text = "Temel Kullanıcı";
                        break;
                    case bitlancer.userTypes.admin:
                        kullaniciTipiLabel.Text = "Üst Düzey Kullanıcı";
                        break;
                    default:
                        kullaniciTipiLabel.Text = "Temel Kullanıcı";
                        break;
                }
                bakiyeLabel.Text = MyUser.money + " ₺";
                urunlerDatagrid.DataSource = MyUser.items;
                List<chartItemValue> chartItemList = new List<chartItemValue>();
                if (MyUser.items!=null)
                {
                    foreach (item item in MyUser.items)
                    {
                        chartItemList.Add(new chartItemValue(item.itemName, item.quantity * item.unitPrice));
                    }
                }
                graphic.DataSource = chartItemList;
                graphic.Series["Para"].XValueMember = "itemName";
                graphic.Series["Para"].YValueMembers = "val";
                graphic.DataBind();
                chartItemList.Clear();
                transferlerDatgrid.DataSource = SingletonDB.GetInstance.getItemTransfers(MyUser.id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
            itemData = SingletonDB.GetInstance.getItems();
            lastOrdersData = SingletonDB.GetInstance.getLastOrders(userID);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setUserToUI();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(numericUpDown1.Value);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}
