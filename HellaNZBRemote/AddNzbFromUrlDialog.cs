using System;
using System.Windows.Forms;

namespace HellaNzbRemote
{
    public partial class AddNzbFromUrlDialog : Form
    {
        public String url;

        public AddNzbFromUrlDialog()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            url = textBoxUrl.Text;
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
