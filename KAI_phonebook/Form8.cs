using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KAI_phonebook
{
    public partial class Form8 : Form
    {
        bool edit = false;
        int nn;
        Address curAdr;
        public BindingList<Address> Places { get; set; }
        public Form8(BindingList<Address> places)
        {
            Places = places;
            InitializeComponent();
        }
        public Form8(BindingList<Address> places, int ind)
        {
            edit = true;
            Places = places;
            nn = ind;
            curAdr = places[nn];
            InitializeComponent();
            flatTextBox.Text = curAdr.Flat;
            houseTextBox.Text = curAdr.House;
            streetTextBox.Text = curAdr.Street;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = this.Owner as Form3;
            if (!edit) Places.Add(new Address(flatTextBox.Text, houseTextBox.Text, streetTextBox.Text));
            else
            {
                curAdr.Street = streetTextBox.Text;
                curAdr.House = houseTextBox.Text;
                curAdr.Flat = flatTextBox.Text;
                Places[nn] = curAdr;
            }
            edit = false;
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
