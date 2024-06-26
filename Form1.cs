using ind_work.Interfaces;

namespace ind_work
{
    public partial class Form1 : Form, IView
    {
        private IPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
        }
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public void ShowRole(string role)
        {
            if (role != "Unauthorized")
            {
                Form2 form2 = new Form2(role);
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                lblRole.Text = role;
            }
        }
        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            _presenter.Authorize();
        }

    }
}
