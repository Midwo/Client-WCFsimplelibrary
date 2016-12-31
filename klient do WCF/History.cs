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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        string author = "";
        string message = "";
        bool agentaction = true;

        private void button1_Click(object sender, EventArgs e)
        {
            author = textBox1.Text;
            message = textBox3.Text;
            agentaction = false;
            if (checkBox1.Checked == true)
            {
                agentaction = true;
            }
            send();
        }

        void send(string endpointName = "BasicHttpBinding_IService1")
        {
            Console.WriteLine("SyncCall " + endpointName);
            try
            {
                
                using (klient_do_WCF.ServiceReference1.Service1Client client = new klient_do_WCF.ServiceReference1.Service1Client(endpointName))
                //using (ServiceReference1.IService1 client = new ServiceReference1.IService1(endpointName))
                {
                    ServiceReference1.DataContractIService1WelcomeHistory request = new ServiceReference1.DataContractIService1WelcomeHistory();

                    request.Author = author;
                    request.Message = message;
                    request.AgentAction = agentaction;
                    var response = client.WelcomeHistory(request);
                    //foreach (var mess in response)
                    //{
                    //    ss += mess;
                    //}

                    MessageBox.Show("" + response + "", "MD information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.ToString());
            }
        }
    }
}
