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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string endpointName = "BasicHttpBinding_IService1";
            bool option = false;
            if (checkBox1.Checked == true)
            {
                option = true;
            }
            string selectcombo = comboBox1.SelectedText;
            try
            {

                using (klient_do_WCF.ServiceReference1.Service1Client client = new klient_do_WCF.ServiceReference1.Service1Client(endpointName))
                //using (ServiceReference1.IService1 client = new ServiceReference1.IService1(endpointName))
                {
                    ServiceReference1.DataContractIService1SendOrder request = new ServiceReference1.DataContractIService1SendOrder();

                    request.Adressinfomation = textBox2.Text;
                    request.Clientname = textBox1.Text;
                    request.Country = textBox3.Text;
                    request.Emailclient = textBox4.Text;
                    request.Value = textBox7.Text;
                    request.Optionsend = selectcombo;
                    request.Itemname = textBox6.Text;
                    request.Finishorder = option;
                  
                    var response = client.SendOrder(request);
                    //foreach (var mess in response)
                    //{
                    //    ss += mess;
                    //}

                    MessageBox.Show("" + response + "", "MD information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.ToString());
            }
        }

       
    }
}
