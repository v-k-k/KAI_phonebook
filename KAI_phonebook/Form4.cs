using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KAI_phonebook
{
    public partial class Form4 : Form
    {
        public BindingList<Address> Places { get; set; }
        public Form4(BindingList<Address> places)
        {
            Places = places;
            InitializeComponent();
            placesBindingSource.DataSource = Places;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(Places);
            f8.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (placesDataGridView.CurrentRow != null)
            {
                int selected = placesDataGridView.CurrentRow.Index;
                if (System.Windows.Forms.Application.OpenForms["Form2"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form2"] as Form2).getAdr(selected);
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
            if (placesDataGridView.CurrentRow != null)
            {
                int selected = placesDataGridView.CurrentRow.Index;
                Form8 f8 = new Form8(Places, selected);
                f8.ShowDialog();
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
            if (placesDataGridView.CurrentRow != null)
            {
                int selected = placesDataGridView.CurrentRow.Index;
                Places.Remove(Places[selected]);
            }
        }
    }
}
