using MainLibrary;
using System.Text;
using System.Windows.Forms;
using static MainLibrary.Stream_encryption;

namespace TI_lab2
{
    public partial class MainForm : Form
    {
        const int LFSR = 28;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearAllFields()
        {
            tb_origin_text.Text = "";
            tb_key.Text = "";
            tb_ciphertext.Text = "";
        }

        public void Edit_fields(object sender, EventArgs e)
        {
            btn_cipher.Enabled = (tb_origin_text.Text != "") && (tb_key.Text != "");
        }

        private void btn_cipher_Click(object sender, EventArgs e)
        {
            string origin_text = tb_origin_text.Text;
            string key_string = tb_key.Text;
            string key = "";
            try
            {
                key = Stream_encryption.CreateKey(key_string, LFSR);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            tb_key.Text = key;

            byte[] keyBytes = new byte[Key.polynomial[0]];
            StringBuilder key_buider = new StringBuilder();
            int i = 0;
            for (int j = 0; j < tb_key.Text.Length; j++)
            {
                if (tb_key.Text[j] == '0' || tb_key.Text[j] == '1')
                {
                    keyBytes[i] = (byte)(tb_key.Text[j] - '0');
                    i++;
                    key.Append(tb_key.Text[j]);
                }
            }
            tb_key.Text = key.ToString();

            byte[] generatedKeyBytes = MainLibrary.Stream_encryption.Key.Generate(keyBytes, Encryption.plainText.Length);
            ShowGeneratedKey(generatedKeyBytes);

            Encryption.Encrypt(generatedKeyBytes);
            ShowCipherText(Encryption.cipherText);
        }        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes = File.ReadAllBytes(openFileDialog.FileName);

                Encryption.plainText = new byte[bytes.Length * 8];
                for (int i = 0; i < bytes.Length; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Encryption.plainText[i * 8 + j] = (byte)((bytes[i] >> j) & 0x1);
                    }
                }

                ShowPlainText(Encryption.plainText);

                tb_key.Clear();
                tb_ciphertext.Clear();

                btn_cipher.Enabled = false;
            }

        }        

        private void menu_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] result = new byte[Encryption.cipherText.Length / 8];
                for (int i = 0; i < result.Length; i++)
                {
                    byte oneByte = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        oneByte |= (byte)(Encryption.cipherText[i * 8 + j] << j);
                    }
                    result[i] = oneByte;
                }
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    fileStream.Write(result, 0, result.Length);
                }
            }
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPlainText(byte[] bits)
        {
            tb_origin_text.Text = bits.Length > 32 * 8 ? "Первые 16 байт: " +
                MainLibrary.Stream_encryption.Convert.BitsToString(bits, 0, 16 * 8) +
                Environment.NewLine + "Последние 16 байт: " +
                MainLibrary.Stream_encryption.Convert.BitsToString(bits, bits.Length - 16 * 8, 16 * 8) :
                MainLibrary.Stream_encryption.Convert.BitsToString(bits, 0, bits.Length);
        }

        private void ShowGeneratedKey(byte[] bits)
        {
            tb_key.Text = bits.Length > 32 * 8 ? "Первые 16 байт: " +
                Stream_encryption.Convert.BitsToString(bits, 0, 16 * 8) +
                Environment.NewLine + "Последние 16 байт: " +
                Stream_encryption.Convert.BitsToString(bits, bits.Length - 16 * 8, 16 * 8) :
                Stream_encryption.Convert.BitsToString(bits, 0, bits.Length);
        }

        private void ShowCipherText(byte[] bits)
        {
            tb_ciphertext.Text = bits.Length > 32 * 8 ? "Первые 16 байт: " +
                Stream_encryption.Convert.BitsToString(bits, 0, 16 * 8) +
                Environment.NewLine + "Последние 16 байт: " +
                Stream_encryption.Convert.BitsToString(bits, bits.Length - 16 * 8, 16 * 8) :
                Stream_encryption.Convert.BitsToString(bits, 0, bits.Length);
        }
    }
}
