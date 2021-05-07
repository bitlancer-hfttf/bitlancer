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
        item myItem;
        int itemID=0;
        string islem;
        int x = 0;
        public orderForm(string islem,int itemID)
        {
            this.islem = islem;
            this.itemID = itemID;
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
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = myItem.itemName;
            quantity.Text = myItem.quantity + " Adet Alabilirsiniz";
            itemPriceLabel.Text = myItem.unitPrice + " ₺";
            chart.Series["line"].Points.AddXY(DateTime.Now,myItem.unitPrice);
            if (x >= 250)
            {
                chart.Series["line"].Points.RemoveAt(0);

            }
        }
    }
}
