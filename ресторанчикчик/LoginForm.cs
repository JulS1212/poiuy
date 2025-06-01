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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowRoleControl(UserControl control)
        {
            panelUI.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelUI.Controls.Add(control);
        }
        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEmployee.Checked)
            {
                ShowRoleControl(new EmployeeControl());
            }
        }

        private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClient.Checked)
            {
                ShowRoleControl(new ClientControl1());
            }
        }
    }
}
