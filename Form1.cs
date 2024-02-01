namespace UX_UI_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text;
            string email = Emailtxt.Text;
            string password = Passwordtxt.Text;
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            bool x = false;
            bool y = false;

            if (name.Length == 0)
            {
                MessageBox.Show("Name Field Can't Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var item in specialChar)
            {
                if (password.Contains(item)) x = true;
            }

            if (x == false)
            {
                MessageBox.Show("Password Must Contain A Special Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (email.Length == 0)
            {
                MessageBox.Show("Email Field Can't Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (password.Contains("@")) y = true;
            if (y == false)
            {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (password.Length < 5)
                {
                    MessageBox.Show("Password Must Be 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Acccount Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            /*private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {

            }*/
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {

        }
    }
}