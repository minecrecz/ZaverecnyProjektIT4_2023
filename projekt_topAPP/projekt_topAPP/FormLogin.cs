using projekt_topAPP.tøídy;

namespace projekt_topAPP
{
    public partial class FormLogin : Form
    {

        public User? LoggedUser { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = txtUsername.Text != string.Empty && txtPassword.Text != string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? user = SqlRepository.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Špatné pøihlašovací údaje");
            }
            else
            {
                LoggedUser = user;
                Close();
            }
        }
    }
}