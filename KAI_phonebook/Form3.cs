using System;
using System.ComponentModel;
using System.Windows.Forms;
using static KAI_phonebook.Form2;

namespace KAI_phonebook
{
    public partial class Form3 : Form
    {
        public BindingList<Human> Fios { get; set; }
        public Form3(BindingList<Human> fios)
        {
            Fios = fios;
            InitializeComponent();
            fiosBindingSource.DataSource = Fios;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(Fios);
            f6.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (fiosDataGridView.CurrentRow != null)
            {
                int selected = fiosDataGridView.CurrentRow.Index;
                Form6 f6 = new Form6(Fios, selected);
                f6.ShowDialog();
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

        private void dataBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (fiosDataGridView.CurrentRow != null)
            {
                int selected = fiosDataGridView.CurrentRow.Index;
                Fios.Remove(Fios[selected]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fiosDataGridView.CurrentRow != null)
            {
                int selected = fiosDataGridView.CurrentRow.Index;
                if (System.Windows.Forms.Application.OpenForms["Form2"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form2"] as Form2).getHum(selected);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }    
}
