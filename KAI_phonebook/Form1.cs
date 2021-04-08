using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KAI_phonebook
{
    public partial class Form1 : Form
    {
        public BindingList<Data> Humans { get; set; }
        Formatter formatter = new Formatter(ObjectType.Data);
        public Form1()
        {
            InitializeComponent();
            Humans = (BindingList<Data>)formatter.Deserialize(File.data);
            humansBindingSource.DataSource = Humans;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(Humans);
            f2.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (humansDataGridView.CurrentRow != null)
            {
                int selected = humansDataGridView.CurrentRow.Index;
                Form2 f2 = new Form2(Humans, selected);
                f2.ShowDialog();
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
            if (humansDataGridView.CurrentRow != null)
            {
                int selected = humansDataGridView.CurrentRow.Index;
                Humans.Remove(Humans[selected]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formatter.Serialize(Humans, File.data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
