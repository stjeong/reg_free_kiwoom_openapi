using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.axKHOpenAPI1.OnEventConnect += AxKHOpenAPI1_OnEventConnect;
        }

        private void AxKHOpenAPI1_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode != 0)
            {
                MessageBox.Show(e.nErrCode.ToString());
            }
            else
            {
                string userId = axKHOpenAPI1.GetLoginInfo("USER_ID");
                this.Text = userId;                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.axKHOpenAPI1.CommConnect() < 0)
            {
                MessageBox.Show("Failed to call CommConnect API");
            }
        }
    }
}
