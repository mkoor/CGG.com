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
    public partial class FormAvailability : Form
    {
        public FormAvailability()
        {
            InitializeComponent();
            ShowFirms();
            ShowCars();
            ShowAvailability();
        }

        void ShowAvailability()
        {
            listViewAvailability.Items.Clear();
            foreach (AvailabilitySet availabilitySet in Program.cGG.AvailabilitySet)
            {
                 ListViewItem item = new ListViewItem(new string[]
                 {
                        availabilitySet.Id.ToString(),
                        availabilitySet.FirmsSet.NameFirm,
                        availabilitySet.CarsSet.Model
                 });
                 item.Tag = availabilitySet;
                 listViewAvailability.Items.Add(item);
                
            }
            listViewAvailability.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        void ShowFirms()
        {
            comboBoxFirm.Items.Clear();
            foreach (FirmsSet firmsSet in Program.cGG.FirmsSet)
            {
                string[] item = { firmsSet.Id.ToString()+". ", firmsSet.NameFirm};
                comboBoxFirm.Items.Add(string.Join(" ", item));
            }
        }


        void ShowCars()
        {
            comboBoxCar.Items.Clear();
            foreach (CarsSet carsSet in Program.cGG.CarsSet)
            {
                string[] item = { carsSet.Id.ToString() + ". ", carsSet.Model };
                comboBoxCar.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCar.SelectedItem != null && comboBoxFirm.SelectedItem != null)
            {
                AvailabilitySet availabilitySet = new AvailabilitySet();
                availabilitySet.IdCar = Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]);
                availabilitySet.IdFirm = Convert.ToInt32(comboBoxFirm.SelectedItem.ToString().Split('.')[0]);
            }
            else MessageBox.Show("Выберите автомобиль и фирму!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBoxFirm_SelectedIndexChanged(object sender, EventArgs e)
        {  
        }

        private void listViewAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                AvailabilitySet availabilitySet = listViewAvailability.SelectedItems[0].Tag as AvailabilitySet;

                comboBoxCar.Text = availabilitySet.CarsSet.Model;
                comboBoxFirm.Text = availabilitySet.FirmsSet.NameFirm;
            }
            else
            {
                comboBoxFirm.SelectedItem = null;
                comboBoxCar.SelectedItem = null;
            }
        }

        private void listViewAvailability2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
