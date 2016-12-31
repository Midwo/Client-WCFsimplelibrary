using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klient_do_WCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string endpointName = "BasicHttpBinding_IService1";

        private void welcomeHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History m = new History();
            m.Show();
        }

        private void dateReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                using (klient_do_WCF.ServiceReference1.Service1Client client = new klient_do_WCF.ServiceReference1.Service1Client(endpointName))
                //using (ServiceReference1.IService1 client = new ServiceReference1.IService1(endpointName))
                {
                    var s = client.DateReturn();



                    MessageBox.Show("" + s + "", "MD information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.ToString());
            }
        }

        private void readTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                using (klient_do_WCF.ServiceReference1.Service1Client client = new klient_do_WCF.ServiceReference1.Service1Client(endpointName))
                //using (ServiceReference1.IService1 client = new ServiceReference1.IService1(endpointName))
                {
                    var s = client.ReadText();



                    MessageBox.Show("" + s + "", "MD information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.ToString());
            }
        }

        private void sendOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order m = new Order();
            m.Show();
        }
    }
}



