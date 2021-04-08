using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KAI_phonebook
{
    public partial class Form6 : Form
    {
        bool edit = false;
        int nn;
        string sex = "";
        Human curHum;
        public BindingList<Human> Fios { get; set; }
        public Form6(BindingList<Human> fios)
        {
            edit = false;
            Fios = fios;
            InitializeComponent();
            radioButton1.Checked = true;
        }
        public Form6(BindingList<Human> fios, int ind)
        {
            edit = true;
            Fios = fios;
            nn = ind;
            curHum = fios[nn];
            InitializeComponent();
            bdateTextBox.Text = curHum.Bdate;
            lnameTextBox.Text = curHum.Lname;
            fnameTextBox.Text = curHum.Fname;
            mnameTextBox.Text = curHum.Mname;
            if (curHum.Sex == "male") radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = this.Owner as Form3;
            if (radioButton1.Checked) sex = "male";
            else sex = "female";
            if (!edit) Fios.Add(new Human(lnameTextBox.Text, fnameTextBox.Text, mnameTextBox.Text, sex, bdateTextBox.Text));
            else
            {
                curHum.Lname = lnameTextBox.Text;
                curHum.Fname = fnameTextBox.Text;
                curHum.Mname = mnameTextBox.Text;
                curHum.Bdate = bdateTextBox.Text;
                curHum.Sex = sex;
                Fios[nn] = curHum;
            }
            edit = false;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
