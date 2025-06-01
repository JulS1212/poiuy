using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ресторанчикчик
{
    public partial class MainFormWaiter : Form
    {
        public MainFormWaiter()
        {
            InitializeComponent();
        }

        private void button1Profilee_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.ShowDialog();
        }
    }
}
