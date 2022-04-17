using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mms_ernet9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File1.Filter = "(*.jpg)|*.jpg";
        }

        private void File1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string fname;
            File1.ShowDialog();
            fname = File1.FileName;
            pct.Image = Image.FromFile(fname);
            MessageBox.Show($"{fname}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname;
            saveFile1.ShowDialog();
            fname = File1.FileName;
            pct.Image.Save(fname);
        }
    }
}
