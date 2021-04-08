using System;
using System.ComponentModel;
using System.Windows.Forms;
using static KAI_phonebook.Form1;

namespace KAI_phonebook
{
    public partial class Form2 : Form
    {
        bool edit = false;
        int nn;
        Data curData;
        Human curHum;
        Address curAdr;
        Phone curPh;
        public BindingList<Human> Fios { get; set; }
        Formatter fiosFormatter = new Formatter(ObjectType.Human);
        public BindingList<Address> Places { get; set; }
        Formatter placesFormatter = new Formatter(ObjectType.Address);
        public BindingList<Phone> Numbers { get; set; }
        Formatter numbersFormatter = new Formatter(ObjectType.Phone);
        public BindingList<Data> Humans { get; set; }
        public Form2(BindingList<Data> humans)
        {
            Humans = humans;
            InitializeComponent();
            Fios = (BindingList<Human>)fiosFormatter.Deserialize(File.fios);
            Places = (BindingList<Address>)placesFormatter.Deserialize(File.places);
            Numbers = (BindingList<Phone>)numbersFormatter.Deserialize(File.numbers);
        }
        public Form2(BindingList<Data> humans, int ind)
        {
            edit = true;
            Humans = humans;
            nn = ind;
            curData = humans[nn];
            Human tmpHum = new Human(curData.Lname, curData.Fname, curData.Mname, curData.Sex, curData.Bdate);
            curHum = tmpHum;
            Address tmpAdr = new Address(curData.Street, curData.House, curData.Flat);
            curAdr = tmpAdr;
            Phone tmpPh = new Phone(curData.Number, curData.Type);
            curPh = tmpPh;
            InitializeComponent();
            Fios = (BindingList<Human>)fiosFormatter.Deserialize(File.fios);
            Places = (BindingList<Address>)placesFormatter.Deserialize(File.places);
            Numbers = (BindingList<Phone>)numbersFormatter.Deserialize(File.numbers);

            fioTextBox.Text = curData.Lname + ' ' + curData.Fname + ' ' + curData.Mname;
            addressTextBox.Text = curData.Street + ' ' + curData.House + ' ' + curData.Flat;
            numberTextBox.Text = curData.Type + ' ' + curData.Number; ;
            emailTextBox.Text = curData.Email;
        }
        public void getHum(int ind)
        {
            curHum = Fios[ind];
            fioTextBox.Text = curHum.Lname + ' ' + curHum.Fname + ' ' + curHum.Mname;
        }
        public void getAdr(int ind)
        {
            curAdr = Places[ind];
            addressTextBox.Text = curAdr.Street + ' ' + curAdr.House + ' ' + curAdr.Flat;
        }
        public void getPh(int ind)
        {
            curPh = Numbers[ind];
            numberTextBox.Text = curPh.Type + ' ' + curPh.Number;
        }
        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberLabel_Click(object sender, EventArgs e)
        {

        }
        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void fioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fioLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(Fios);
            f3.ShowDialog();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (fioTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "" && emailTextBox.Text != "")
            {
                if (!edit) Humans.Add(new Data(curHum.Lname, curHum.Fname, curHum.Mname, curHum.Sex, curHum.Bdate, curAdr.Street, curAdr.House, curAdr.Flat, curPh.Number, curPh.Type, emailTextBox.Text));
                else
                {
                    Data curData = new Data(curHum.Lname, curHum.Fname, curHum.Mname, curHum.Sex, curHum.Bdate, curAdr.Street, curAdr.House, curAdr.Flat, curPh.Number, curPh.Type, emailTextBox.Text);
                    Humans[nn] = curData;
                }
                edit = false;
                Close();
                fiosFormatter.Serialize(Fios, File.fios);
                placesFormatter.Serialize(Places, File.places);
                numbersFormatter.Serialize(Numbers, File.numbers);
            }
            else
            {
                MessageBox.Show(
                        MessageWindow.message,
                        MessageWindow.header,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(Places);
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(Numbers);
            f5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nn >= 0)
            {
                Fios.Remove(Fios[nn]);
                fioTextBox.Text = WindowLabels.deleted;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nn >= 0)
            {
                Places.Remove(Places[nn]);
                addressTextBox.Text = WindowLabels.deleted;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nn >= 0)
            {
                Numbers.Remove(Numbers[nn]);
                numberTextBox.Text = WindowLabels.deleted;
            }
        }
    }
}
