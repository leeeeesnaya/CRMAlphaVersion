using System;
using System.Windows.Forms;

namespace CRMAlphaVersion
{
    public partial class Loading : Form
    {
        public string UserName { get; set; }
        public string UserPosition { get; set; }

        public Loading()
        {
            InitializeComponent();
        }


        private void Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            if(progressBar.Value == 100)
            {
                timer1.Stop();
                Main mainForm = new Main(UserName, UserPosition);
                this.Hide();
                mainForm.FormClosed += (s, args) => { this.Close(); };
                mainForm.Show();
            }
            else
            {
                progressBar.Value += 1;
                label_value.Text = (Convert.ToInt32(label_value.Text) + 1).ToString();
            }
        }
    }
}
