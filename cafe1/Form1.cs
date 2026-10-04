namespace cafe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SebeteElaveEt("Tort", 4.50m);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
        }

        private void SebeteElaveEt(string yemekAdi, decimal qiymet)
        {
            listBox1.Items.Add(yemekAdi + " - " + qiymet.ToString("0.00") + " AZN");
        }

        private decimal SebetHesabla()
        {
            decimal umumi = 0;

            foreach (string item in listBox1.Items)
            {
                string[] hisse = item.Split('-');

                if (hisse.Length > 1)
                {
                    string qiymet = hisse[1].Replace("AZN", "").Trim();

                    if (decimal.TryParse(qiymet, out decimal q))
                    {
                        umumi += q;
                    }
                }
            }

            return umumi;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Cola", 2.00m);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Şirə", 3.00m);

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Burger", 6.00m);

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Sendviç", 5.00m);

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Pizza", 7.00m);
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Mafin", 3.50m);

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Hot Dog", 4.00m);

        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            SebeteElaveEt("Peçenye", 2.50m);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            decimal hesab = SebetHesabla();

            if (!decimal.TryParse(maskedTextBox1.Text, out decimal mebleg))
            {
                MessageBox.Show("Məbləği düzgün daxil edin.");
                return;
            }

            if (mebleg < hesab)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                return;
            }

            decimal qaliq = mebleg - hesab;

            textBox2.Text = qaliq.ToString("0.00") + " AZN";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox2.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Səbətdən silmək üçün yemək seçin.");
                return;
            }

            string silinenYemek = listBox1.SelectedItem.ToString();
            string yemekAdi = silinenYemek.Split('-')[0].Trim();

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            MessageBox.Show(yemekAdi + " yeməyi səbətdən silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
                "Xanalar sıfırlansınmı?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cavab == DialogResult.Yes)
            {
                maskedTextBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                listBox1.Items.Clear();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            decimal umumi = SebetHesabla();

            textBox3.Text = umumi.ToString("0.00") + " AZN";
        }
    }
}