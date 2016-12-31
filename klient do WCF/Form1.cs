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
        private static void SyncCall(string endpointName = "BasicHttpBinding_IService1")
        {
            Console.WriteLine("SyncCall " + endpointName);
            try
            {
                using (klient_do_WCF.ServiceReference1.Service1Client client = new klient_do_WCF.ServiceReference1.Service1Client(endpointName))
                //using (ServiceReference1.IService1 client = new ServiceReference1.IService1(endpointName))
                {
                    ServiceReference1.DataContractIService1WelcomeHistory request = new ServiceReference1.DataContractIService1WelcomeHistory();
                    var ss = "";
                    request.Author = "Masło";
                    request.Message = "lubie placki";
                    request.AgentAction = true;
                    var response = client.WelcomeHistory(request);
                    //foreach (var mess in response)
                    //{
                    //    ss += mess;
                    //}

                    MessageBox.Show("" + response + "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SyncCall();
        }
    }


}
