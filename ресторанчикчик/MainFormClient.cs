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
    public partial class MainFormClient : Form
    {
        public MainFormClient()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();

        }
    }
}
