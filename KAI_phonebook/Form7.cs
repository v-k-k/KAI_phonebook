using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KAI_phonebook
{
    public partial class Form7 : Form
    {
        bool edit = false;
        int nn;
        string type = "";
        Phone curNum;
        public BindingList<Phone> Numbers { get; set; }
        public Form7(BindingList<Phone> numbers)
        {
            Numbers = numbers;
            InitializeComponent();
            radioButton1.Checked = true;
        }
        public Form7(BindingList<Phone> numbers, int ind)
        {
            edit = true;
            Numbers = numbers;
            nn = ind;
            curNum = numbers[nn];
            InitializeComponent();
            numberTextBox.Text = curNum.Number;
            if (curNum.Type == "cell-phone") radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = this.Owner as Form3;
            if (radioButton1.Checked) type = "cell-phone";
            else type = "house-phone";
            if (!edit) Numbers.Add(new Phone(numberTextBox.Text, type));
            else
            {
                curNum.Number = numberTextBox.Text;
                curNum.Type = type;
                Numbers[nn] = curNum;
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
