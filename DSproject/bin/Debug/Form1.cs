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

namespace DSproject
{
    public partial class Form1 : Form
    {
        
        FormSetting setting = new FormSetting();
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("config.txt")==false)
                {
                File.Create("config.txt");
                MessageBox.Show("Enter your details on setting form");
                setting.Show();
                
                }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            
            setting.Show();
        }
    }
}
