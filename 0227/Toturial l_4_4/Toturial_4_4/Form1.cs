namespace Toturial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MSG_Click(object sender, EventArgs e)
        {

        }

        private void textBox_KM_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double km, oil, ave;

            if (double.TryParse(textBox_KM.Text, out km))
            {
                if (double.TryParse(textBox_OIL.Text, out oil))
                {
                    ave = km / oil;
                    MSG.Text = "�����o�ӡG" + ave.ToString("f2") + "����/����";
                }
                else
                {
                    MessageBox.Show("�п�J�Ʀr");
                    textBox_OIL.Focus();
                    textBox_OIL.Text = "";
                }

            }

            else
            {
                MessageBox.Show("�п�J�Ʀr");
                textBox_KM.Focus();
                textBox_KM.Text = "";
            }

            km = double.Parse(textBox_KM.Text);
            oil = double.Parse(textBox_OIL.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
