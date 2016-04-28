using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SaintSender
{
    public partial class Form1 : Form
    {
        string smtpAddress = "smtp.gmail.com";
        int portNumber = 587;
        bool enableSSL = true;

        string emailFrom = "mrpapsu@gmail.com";
        string password = "kakas0526HICEMI";

        public Form1()
        {
            InitializeComponent();
        }
        

        private void userNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
