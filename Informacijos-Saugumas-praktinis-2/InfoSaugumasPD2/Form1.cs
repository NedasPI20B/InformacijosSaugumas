using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace InfoSaugumasPD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int keysize = 256;
        private const int iterations = 1000;
        public string fileContent = " ";

        private static string getString(byte[] b)
        {
            return Encoding.UTF8.GetString(b);
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            bool canRun = true;

            try
            {
                if (encryptTxt.Text == null || encryptTxt.Text.Length <= 0)
                {
                    MessageBox.Show("Insert text you want to encrypt !");
                    canRun = false;
                }

                if (modeList.SelectedIndex == -1)
                {
                    MessageBox.Show("Select cipher Mode");
                    canRun = false;
                }

                if (keyTxt.Text == null || keyTxt.Text.Length <= 0)
                {
                    MessageBox.Show("Insert Encryption key !");
                    canRun = false;
                }

                if (ivTxt.Text == null )
                {
                    MessageBox.Show("Insert IV with 32 Characters !");
                    canRun = false;
                }

                if (canRun != false)
                {
                    if (modeList.SelectedItem.ToString() == "CBC")
                    {
                        encryptedTxt.Text = Encrypt(encryptTxt.Text, keyTxt.Text, ivTxt.Text);
                        File.WriteAllText(@"C:\Users\Nedas\OneDrive\Stalinis kompiuteris\Informacijos saugumas\Informacijos-Saugumas-praktinis-2\EncryptedCBC.txt", encryptedTxt.Text);
                        decryptedTxt.Text = Decrypt(encryptedTxt.Text, keyTxt.Text, ivTxt.Text);
                    }

                    if (modeList.SelectedItem.ToString() == "ECB")
                    {
                        Console.WriteLine("TEXT: {0}", encryptTxt.Text);
                        Console.WriteLine("Key: {0}", keyTxt.Text);
                        byte[] text = Encoding.UTF8.GetBytes(encryptTxt.Text);
                        byte[] key = Encoding.UTF8.GetBytes(keyTxt.Text);
                        
                        encryptedTxt.Text = Convert.ToBase64String(EncryptECB(text, key));
                        Console.WriteLine("ENC {0}", encryptedTxt.Text);
                        File.WriteAllText(@"C:\Users\Nedas\OneDrive\Stalinis kompiuteris\Informacijos saugumas\Informacijos-Saugumas-praktinis-2\EncryptedECB.txt", encryptedTxt.Text);
                        byte[] enc = EncryptECB(text, key);
                        
                        byte[] dec = DecryptECB(enc, key);

                        //decryptedTxt.Text = getString(dec);
                        Console.WriteLine("3");
                        decryptedTxt.Text = Encoding.UTF8.GetString(dec);
                        Console.WriteLine("Dec text {0}", decryptedTxt.Text);
                        File.WriteAllText(@"C:\Users\Nedas\OneDrive\Stalinis kompiuteris\Informacijos saugumas\Informacijos-Saugumas-praktinis-2\DecryptedECB.txt", decryptedTxt.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EncryptBtn Error: {0}", ex.Message);
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool canRun = true;

                /* if (decryptTxt.Text == null || decryptTxt.Text.Length <= 0)
                 {
                     MessageBox.Show("Insert text you want to decrypt !");
                     canRun = false;
                 }
                */
                if (modeList.SelectedIndex == -1)
                {
                    MessageBox.Show("Select cipher Mode");
                    canRun = false;
                }

                if (keyTxt.Text == null || keyTxt.Text.Length <= 0)
                {
                    MessageBox.Show("Insert Decryption key !");
                    canRun = false;
                }

                if (canRun != false)
                {
                    if (modeList.SelectedItem.ToString() == "CBC")
                    {
                        decryptedTxt.Text = Decrypt(fileContent, keyTxt.Text, ivTxt.Text);
                        //decryptedTxt.Text = Decrypt(decryptTxt.Text, keyTxt.Text, ivTxt.Text); // Naudojamas jeigu norima decryptint tiesiog ivesta string
                        File.WriteAllText(@"C:\Users\Nedas\OneDrive\Stalinis kompiuteris\Informacijos saugumas\Informacijos-Saugumas-praktinis-2\DecryptedCBC.txt", decryptedTxt.Text);
                    }

                    if (modeList.SelectedItem.ToString() == "ECB")
                    {

                        Console.WriteLine(fileContent);
                        byte[] data = Convert.FromBase64String(fileContent);
                        byte[] key = Encoding.UTF8.GetBytes(keyTxt.Text);

                        byte[] dec = DecryptECB(data, key);
                        Console.WriteLine("DEC {0}", Encoding.UTF8.GetString(dec));
                        decryptedTxt.Text = Encoding.UTF8.GetString(dec);
                        File.WriteAllText(@"C:\Users\Nedas\OneDrive\Stalinis kompiuteris\Informacijos saugumas\Informacijos-Saugumas-praktinis-2\DecryptedECB.txt", decryptedTxt.Text);
                    }
                }
                //Decrypt(decryptTxt.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

        public static string Encrypt(string plainText, string passPhrase, string IV)
        {
            // Salt random generuojamas bet ir lieka toks pat tam atvejui jeigu iskarto reikia ir decryptint teksta
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Encoding.UTF8.GetBytes(IV); //Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, iterations))
            {
               
                var keyBytes = password.GetBytes(keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        Console.WriteLine("IV:  {0}", Convert.ToBase64String(ivStringBytes));
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Sukuria paskutinius bytes kaip jungini random salt bytes, random iv bytes ir šifruoto teksto bytes
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase, string ivBytes)
        {
            // Gaunam pilnus Bytes kurie sudaromi iš 32 Bytes salt + 32 Bytes IV ir n bytes šifruoto teksto
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Gaunam saltBytes išimdami 32 bytes iš duoto "cipherText"
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(keysize / 8).ToArray();

            // gaunam Ivesta IV
            var ivStringBytes = Encoding.UTF8.GetBytes(ivBytes).ToArray(); //cipherTextBytesWithSaltAndIv.Skip(keysize / 8).Take(keysize / 8).ToArray();
            // Gauname šifruota teksta išimdami pirmus 64 bytes iš cipherText string
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, iterations))
            {
                var keyBytes = password.GetBytes(keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes duos mums 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Užpildom masyva su cryptografiniais bytes
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            fileContent = string.Empty;
            fileNameTxt.Text = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileNameTxt.Text = ofd.FileName;
                    var fileStream = ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        // Console.WriteLine(fileContent);
                    }
                }
            }
        }

        public static byte[] EncryptECB(byte[] data, byte[] key)
        {
            using (DESCryptoServiceProvider csp = new DESCryptoServiceProvider())
            {
                //csp.KeySize = 256;
                //csp.BlockSize = 128;
                csp.Key = key;
                csp.Padding = PaddingMode.Zeros;
                csp.Mode = CipherMode.ECB;
                ICryptoTransform encrypter = csp.CreateEncryptor();
                return encrypter.TransformFinalBlock(data, 0, data.Length);
            }
        }

        private static byte[] DecryptECB(byte[] data, byte[] key)
        {
            using (DESCryptoServiceProvider csp = new DESCryptoServiceProvider())
            {
                //csp.KeySize = 256;
                //csp.BlockSize = 128;
                csp.Key = key;
                csp.Padding = PaddingMode.Zeros;
                csp.Mode = CipherMode.ECB;
                //Console.WriteLine("DEC DATA {0}", Convert.ToBase64String(data));
                ICryptoTransform decrypter = csp.CreateDecryptor();
                return decrypter.TransformFinalBlock(data, 0, data.Length);
            }
        }

        private void cleardecBtn_Click(object sender, EventArgs e)
        {
            decryptedTxt.Text = string.Empty;
        }

    }
}