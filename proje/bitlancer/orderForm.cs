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
    public partial class orderForm : Form
    {
        DataTable lastOrdersData;
        item myItem;
        int itemID=0,userID=0;
        bitlancer.orderTypes islem;
        int x = 0;
        public orderForm(bitlancer.orderTypes islem,int userID,int itemID)
        {
            this.islem = islem;
            this.itemID = itemID;
            this.userID = userID;
            InitializeComponent();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            timer1.Start();
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
            myItem = SingletonDB.GetInstance.getItemOrder(itemID);
            lastOrdersData = SingletonDB.GetInstance.getLastOrders(userID,itemID); 
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = myItem.itemName;
            quantity.Text = "Maksimum Miktar: "+myItem.quantity ;
            itemPriceLabel.Text = myItem.unitPrice + " ₺ : "+ chart.Series["line"].Points.Count();
            transferlerDatgrid.DataSource = lastOrdersData;
            if (quantityTextBox.Text != "")
            {
                try
                {
                    valTextBox.Text = (Convert.ToDouble(quantityTextBox.Text) * myItem.unitPrice).ToString();
                }
                catch (Exception)
                {
                }
            }
            if (x >= 250)
            {
                chart.Series["line"].Points.RemoveAt(0);
            }
            else
            {
                x++;
            }
            chart.Series["line"].Points.AddXY(DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second,myItem.unitPrice);
        }
    }
}
