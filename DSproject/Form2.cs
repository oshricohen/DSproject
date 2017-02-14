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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("config.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(tbPath.Text);
            sw.WriteLine(tbUser.Text);
            sw.WriteLine(tbPassword.Text);
            sw.WriteLine(tbName.Text);
            sw.WriteLine(tbPort.Text);
            sw.Close();
            fs.Close();
            this.Close();
        }
    }
}
