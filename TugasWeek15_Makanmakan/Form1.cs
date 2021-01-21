using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek15_Makanmakan
{

    public partial class Form1 : Form
    {
        string[] makanan = new string[24];
        string[] minuman = new string[24];
        public Form1()
        {
            InitializeComponent();

            listBoxKiri.Items.Add("Mie Instan");
            listBoxKiri.Items.Add("Telor");
            listBoxKiri.Items.Add("Susu Sapi");
            listBoxKiri.Items.Add("Kopi");
            listBoxKiri.Items.Add("Roti");
            listBoxKiri.Items.Add("Keju");
            listBoxKiri.Items.Add("Daging Giling");
            listBoxKiri.Items.Add("Teh");
            listBoxKiri.Items.Add("Bir");

            makanan[0] = ("Mie Instan");
            makanan[1] = ("Telor");
            makanan[2] = ("Roti");
            makanan[3] = ("Keju");
            makanan[4] = ("Daging Giling");

            minuman[0] = ("Susu Sapi");
            minuman[1] = ("Kopi");
            minuman[2] = ("Teh");
            minuman[3] = ("Bir");
        }
        int countermakanan = 4;
        int counterminuman = 3;
        private void buttonInput_Click(object sender, EventArgs e)
        {
            // add items
            if (radioButtonMakanan.Checked == true && textBoxNamaitem.Text != "" || radioButtonMinuman.Checked == true && textBoxNamaitem.Text != "")
            {
                if (radioButtonMakanan.Checked == true)
                {
                    bool makan = false;
                    for (int i = 0; i < listBoxKiri.Items.Count; i++)
                    {
                        if (textBoxNamaitem.Text == makanan[i])
                        {
                            MessageBox.Show("Sudah terisi");
                            makan = true;
                        }
                    }
                    while (makan == false)
                    {
                        countermakanan++;
                        makanan[countermakanan] = textBoxNamaitem.Text;
                        listBoxKiri.Items.Add(textBoxNamaitem.Text);
                        makan = true;
                    }
                    
                }
                else if (radioButtonMinuman.Checked == true)
                {
                    bool minum = false;
                    for (int i = 0; i < listBoxKiri.Items.Count; i++)
                    {
                        if (textBoxNamaitem.Text == minuman[i])
                        {
                            MessageBox.Show("Sudah terisi");
                            minum = true;
                        }
                    }
                    while (minum == false)
                    {
                        counterminuman++;
                        minuman[counterminuman] = textBoxNamaitem.Text;
                        listBoxKiri.Items.Add(textBoxNamaitem.Text);
                        minum = true;
                    }
                }
                
                radioButtonMakanan.Checked = false;
                radioButtonMinuman.Checked = false;
                textBoxNamaitem.Text = "";
            }
            else
            {
                MessageBox.Show("Tolong yang bener ya zeyenkkk!!!");
            }
        }

        private void buttonPindah_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxKiri.SelectedItems.Count; i++)
            {
                if (listBoxKanan.Items.Contains(listBoxKiri.SelectedItems[i]))
                {

                }
                else
                {
                    listBoxKanan.Items.Add(listBoxKiri.SelectedItems[i]);
                }
            }
            listBoxKiri.ClearSelected();
            checkBoxMakanan.Checked = false;
            checkBoxMinuman.Checked = false;
            
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            if (listBoxKanan.SelectedItems.Count != 0)
            {
                for (int i = listBoxKanan.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBoxKanan.Items.Remove(listBoxKanan.SelectedItems[i]);
                }
            }
            else if (listBoxKanan.SelectedItems.Count == 0)
            {
                listBoxKanan.Items.Clear();
            }
        }

        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {
            listBoxKiri.ClearSelected();
            if (checkBoxMakanan.Checked == true)
            {
                for (int i = 0; i < makanan.Length; i++)
                {
                    listBoxKiri.Text = makanan[i];
                }
            }
            if (checkBoxMinuman.Checked == true)
            {
                for (int j = 0; j < minuman.Length; j++)
                {
                    listBoxKiri.Text = minuman[j];
                }
            }
            //else
            //{
            //    listBoxKiri.ClearSelected();
            //}

        }

        private void listBoxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxKiri.SelectionMode = SelectionMode.MultiSimple;
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {
            listBoxKiri.ClearSelected();
            if (checkBoxMakanan.Checked == true)
            {
                for (int i = 0; i < makanan.Length; i++)
                {
                    listBoxKiri.Text = makanan[i];
                }
            }
            if (checkBoxMinuman.Checked == true)
            {
                for (int j = 0; j < minuman.Length; j++)
                {
                    listBoxKiri.Text = minuman[j];
                }
            }
            //else
            //{
            //    listBoxKiri.ClearSelected();
            //}
        }

        private void listBoxKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxKanan.SelectionMode = SelectionMode.MultiSimple;
        }
    }
}
