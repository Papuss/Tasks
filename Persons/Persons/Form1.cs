using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
namespace Persons
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [
        private void saveButton_Click(object sender, EventArgs e)
        {
            Person person1 = new Person(nameTextbox.Text,adresstextbox.Text,Convert.ToInt32(phoneTextbox.Text));
            StreamWriter file = new StreamWriter("c:\\Codecool\\személy + "{0}" + .txt ",person1.SerialNumber);
            file.Write(person1.Name + " ");
            file.Write(person1.PhoneNum + " ");
            file.Write(person1.Adress + "\n");
            file.Flush();
            file.Close();
        }
    }
}
