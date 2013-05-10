using System;
using System.Windows.Forms;

namespace HellaNzbRemote
{
    public partial class AddNzbFromNewzbinIdDialog : Form
    {
        public string newzbinId;

        public AddNzbFromNewzbinIdDialog()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            newzbinId = textBoxNewzbinId.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
