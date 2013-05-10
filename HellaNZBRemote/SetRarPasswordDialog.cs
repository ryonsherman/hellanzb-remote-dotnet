using System;
using System.Windows.Forms;

namespace HellaNzbRemote
{
    public partial class SetRarPasswordDialog : Form
    {
        public String rarPassword;

        public SetRarPasswordDialog(string currentRarPassword)
        {
            InitializeComponent();

            textBoxRarPassword.Text = currentRarPassword;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRarPassword.UseSystemPasswordChar = (checkBoxShowPassword.Checked) ? false : true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            rarPassword = textBoxRarPassword.Text;
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
