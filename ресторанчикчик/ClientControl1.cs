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
    public partial class ClientControl1 : UserControl
    {
        public ClientControl1()
        {
            InitializeComponent();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            MainFormClient  form = new MainFormClient();
            form.ShowDialog();
        }
    }
}
