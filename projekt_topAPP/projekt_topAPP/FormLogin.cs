using projekt_topAPP.tøídy;

namespace projekt_topAPP
{
    public partial class FormLogin : Form
    {
        sql_repository sql_Repository;
        public FormLogin()
        {
            InitializeComponent();
            sql_Repository = new sql_repository();
 


        }/*
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = sql_Repository.GetUser(txtUsername.Text.Trim());
            if (user != null)
            {
                if (user.VerifyPassword(txtPassword.Text))
                {
                    var mainForm = new FormMain(user);
                    mainForm.Show(this);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    Hide();
                    return;
                }
            }
            MessageBox.Show("Username or password incorrect.");
        } */
    }
}