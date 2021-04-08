using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KAI_phonebook
{
    public partial class Form5 : Form
    {
        public BindingList<Phone> Numbers { get; set; }
        public Form5(BindingList<Phone> numbers)
        {
            Numbers = numbers;
            InitializeComponent();
            numbersBindingSource.DataSource = Numbers;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void dataBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(Numbers);
            f7.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (numbersDataGridView.CurrentRow != null)
            {
                int selected = numbersDataGridView.CurrentRow.Index;
                if (System.Windows.Forms.Application.OpenForms["Form2"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form2"] as Form2).getPh(selected);
                }
                Close();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (numbersDataGridView.CurrentRow != null)
            {
                int selected = numbersDataGridView.CurrentRow.Index;
                Form7 f7 = new Form7(Numbers, selected);
                f7.ShowDialog();
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (numbersDataGridView.CurrentRow != null)
            {
                int selected = numbersDataGridView.CurrentRow.Index;
                Numbers.Remove(Numbers[selected]);
            }
        }
    }
}
