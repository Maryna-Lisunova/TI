using LAlgoritms;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TI3
{
    public partial class MainForm : Form
    {
        Rabin rabin;
        byte[] starttext;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Count_n()
        {
            tb_n.Text = Convert.ToString(Convert.ToUInt32(tb_p.Text) * Convert.ToUInt32(tb_q.Text));
        }

        private void tb_q_TextChanged(object sender, EventArgs e)
        {
            if (tb_p.Text != "" && tb_q.Text != "")
            {
                Count_n();
            }
            else
            {
                tb_n.Text = "";
            }
        }

        private void btn_dosmth_Click(object sender, EventArgs e)
        {
            if (tb_p.Text == "" || tb_q.Text == "" || tb_b.Text == "" || tb_plaintext.Text == "")
            {
                MessageBox.Show("¬ведите все необходимые данные.");
                return;
            } 

            try
            {
                rabin = new Rabin(BigInteger.Parse(tb_p.Text), BigInteger.Parse(tb_q.Text), BigInteger.Parse(tb_b.Text));
                rabin.plainText = starttext;
                BigInteger[] ciphertext = rabin.Encrypt();
                tb_ciphertext.Text = String.Join(" ", ciphertext);
                rabin.CipherTextToBytes(ciphertext);
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.Message, "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                starttext = File.ReadAllBytes(openFileDialog.FileName);

                tb_plaintext.Text = String.Join(" ", starttext);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                    writer.Write(rabin.cipherText, 0, rabin.cipherText.Length);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_undocipher_Click(object sender, EventArgs e)
        {
            if (tb_p.Text == "" || tb_q.Text == "" || tb_b.Text == "" || tb_plaintext.Text == "")
            {
                MessageBox.Show("¬ведите все необходимые данные.");
                return;
            }
            try
            {
                rabin = new Rabin(BigInteger.Parse(tb_p.Text), BigInteger.Parse(tb_q.Text), BigInteger.Parse(tb_b.Text));
                rabin.plainText = starttext;
                rabin.Decipher();
                tb_ciphertext.Text = String.Join(" ", rabin.cipherText);
                tb_plaintext.Text = String.Join(" ", rabin.BytesToCipherText(rabin.plainText));
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show(exc.Message, "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
