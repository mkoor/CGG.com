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
    public partial class FormFirms : Form
    {
        public FormFirms()
        {
            InitializeComponent();
            ShowFirms();
        }

        void ShowFirms()
        {
            listViewFirm.Items.Clear();

            foreach (FirmsSet firmsSet in Program.cGG.FirmsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        firmsSet.Id.ToString(), firmsSet.NameFirm, firmsSet.Address,
                        firmsSet.City, firmsSet.Telephone
                });
                item.Tag = firmsSet;
                listViewFirm.Items.Add(item);
            }
            listViewFirm.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormFirms_Load(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FirmsSet firmsSet = new FirmsSet();

                firmsSet.NameFirm = textBoxNameFirm.Text;
                firmsSet.Address = textBoxAddress.Text;
                firmsSet.City= textBoxCity.Text;
                firmsSet.Telephone = textBoxTelephone.Text;

                if (firmsSet.NameFirm == "" || firmsSet.Address == "" || firmsSet.City == "" || firmsSet.Telephone == "")
                {
                    throw new Exception("Обязательные поля не заполнены!");
                }

                Program.cGG.FirmsSet.Add(firmsSet);
                Program.cGG.SaveChanges();
                ShowFirms();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFirm.SelectedItems.Count == 1)
            {
                FirmsSet firmsSet = listViewFirm.SelectedItems[0].Tag as FirmsSet;
                textBoxNameFirm.Text = firmsSet.NameFirm;
                textBoxAddress.Text = firmsSet.Address;
                textBoxCity.Text = firmsSet.City;
                textBoxTelephone.Text = firmsSet.Telephone;
            }
            else
            {
                textBoxNameFirm.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxTelephone.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFirm.SelectedItems.Count == 1)
                {
                    FirmsSet firmsSet = listViewFirm.SelectedItems[0].Tag as FirmsSet;

                    if (textBoxNameFirm.Text == "" || textBoxAddress.Text == "" || textBoxCity.Text == "" || textBoxTelephone.Text == "")
                    {
                        throw new Exception("Обязательные поля не заполнены!");
                    }
                    else
                    {
                        firmsSet.NameFirm = textBoxNameFirm.Text;
                        firmsSet.Address = textBoxAddress.Text;
                        firmsSet.City = textBoxCity.Text;
                        firmsSet.Telephone = textBoxTelephone.Text;
                    }

                    Program.cGG.SaveChanges();
                    ShowFirms();
                }
            } catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFirm.SelectedItems.Count == 1)
                {
                    FirmsSet firmsSet = listViewFirm.SelectedItems[0].Tag as FirmsSet;
                    Program.cGG.FirmsSet.Remove(firmsSet);
                    Program.cGG.SaveChanges();
                    ShowFirms();
                }

                textBoxNameFirm.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxTelephone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
