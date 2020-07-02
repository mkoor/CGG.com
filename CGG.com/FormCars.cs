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
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
            ShowCars();
        }

        void ShowCars()
        {
            listViewCars.Items.Clear();
            foreach (CarsSet carsSet in Program.cGG.CarsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    carsSet.Id.ToString(),carsSet.Model, carsSet.Color.ToString(), carsSet.Price.ToString(),
                    carsSet.NumberState, carsSet.Year
                });
                item.Tag = carsSet;
                listViewCars.Items.Add(item);
            }
            listViewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CarsSet carsSet = new CarsSet();

                if (textBoxModel.Text == "" || textBoxPrice.Text == "" || textBoxNumberState.Text == "" || textBoxYear.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    carsSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    carsSet.Model = textBoxModel.Text;
                    carsSet.NumberState = textBoxNumberState.Text;
                    carsSet.Year = textBoxYear.Text;
                }

                if (comboBoxColor.SelectedItem != null)
                    carsSet.Color = Convert.ToString(comboBoxColor.SelectedItem.ToString().Split('.')[0]);
                else throw new Exception("Обязательные данные не заполнены");

                Program.cGG.CarsSet.Add(carsSet);
                Program.cGG.SaveChanges();
                ShowCars();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                CarsSet carsSet = listViewCars.SelectedItems[0].Tag as CarsSet;

                textBoxPrice.Text = carsSet.Price.ToString();
                comboBoxColor.Text = carsSet.Color.ToString();
                textBoxModel.Text = carsSet.Model;
                textBoxNumberState.Text = carsSet.NumberState;
                textBoxYear.Text = carsSet.Year;
            }
            else
            {
                comboBoxColor.SelectedItem = null;
                textBoxModel.Text = "";
                textBoxNumberState.Text = "";
                textBoxPrice.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCars.SelectedItems.Count == 1)
                {
                    CarsSet carsSet = listViewCars.SelectedItems[0].Tag as CarsSet;

                    if (textBoxModel.Text == "" || textBoxPrice.Text == "" || textBoxNumberState.Text == "" || textBoxYear.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        carsSet.Price = Convert.ToInt32(textBoxPrice.Text);
                        carsSet.Model = textBoxModel.Text;
                        carsSet.NumberState = textBoxNumberState.Text;
                        carsSet.Year = textBoxYear.Text;
                    }

                    if (comboBoxColor.SelectedItem != null)
                        carsSet.Color = Convert.ToString(comboBoxColor.SelectedItem.ToString().Split('.')[0]);
                    else throw new Exception("Обязательные данные не заполнены");

                    Program.cGG.SaveChanges();
                    ShowCars();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCars.SelectedItems.Count == 1)
                {
                    CarsSet carsSet = listViewCars.SelectedItems[0].Tag as CarsSet;
                    Program.cGG.CarsSet.Remove(carsSet);
                    Program.cGG.SaveChanges();
                    ShowCars();
                }

                comboBoxColor.SelectedItem = null;
                textBoxModel.Text = "";
                textBoxNumberState.Text = "";
                textBoxPrice.Text = "";
                textBoxYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void textBoxPrice_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 ) 
            {
                e.Handled = true;
            }
        }
    }
}

