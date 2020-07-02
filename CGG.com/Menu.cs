using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGG.com
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonFirms_Click(object sender, EventArgs e)
        {
            Form formFirms = new FormFirms();
            formFirms.Show();
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            Form formCars = new FormCars();
            formCars.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formAvailability = new FormAvailability();
            formAvailability.Show();
        }
    }
}
