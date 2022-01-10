using System.Net.Mail;

namespace EmailFormatCheckApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            foreach (var email in textBox1.Lines)
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(email);
                }
                catch (Exception ex)
                {
                    textBox2.Text += email + Environment.NewLine;
                }
            }
        }
    }
}