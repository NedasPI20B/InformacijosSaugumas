using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace Informacijos_saugumas_praktinis_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (pTxt.Text == string.Empty || qTxt.Text == string.Empty)
            {
                MessageBox.Show("P, Q, can't be empty !");
            }
            else
            {
                BigInteger p = BigInteger.Parse(pTxt.Text);
                BigInteger q = BigInteger.Parse(qTxt.Text);


                if (encryptTxt.Text == string.Empty)
                {
                    MessageBox.Show("There's no text to encrypt !");
                }
                else if (p == q)
                {
                    MessageBox.Show("Prime numbers cannot have same value !");
                }
                else if (HelperMethods.checkPrime(p) != true)
                {
                    MessageBox.Show("P must be prime number!");
                }
                else if (HelperMethods.checkPrime(q) != true)
                {
                    MessageBox.Show("Q must be prime number!");
                }

                else
                {

                    Cryption rsaWork = new Cryption();
                    rsaWork.rsaEncryption(encryptTxt.Text, p, q);
                    encryptedTxt.Text = rsaWork.Encryption();
                    string createText = encryptedTxt.Text + Environment.NewLine;
                    File.WriteAllText("C:\\Users\\Nedas\\OneDrive\\Stalinis kompiuteris\\Informacijos saugumas\\Informacijos_saugumas_praktinis_3\\Encrypted.txt", createText);
                    //(encryptTxt.Text, p, q);
                }
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if (encryptTxt.Text == string.Empty)
            {
                MessageBox.Show("There's nothing to decrypt !");
            }
            else if (nTxt.Text == string.Empty)
            {
                MessageBox.Show("No value N inserted !");
            }
            else if (eTxt.Text == string.Empty)
            {
                MessageBox.Show("No value E inserted !");
            }
            else
            {

                string[] decText = (encryptTxt.Text).Split(' ');
                BigInteger[] encText = new BigInteger[decText.Length];

                for (int i = 0; i < decText.Length; i++)
                {
                    BigInteger temp = 0;
                    if (BigInteger.TryParse(decText[i], out temp))
                    {
                        if (temp != 0)
                        {
                            encText[i] = BigInteger.Parse(decText[i]);
                        }
                    }
                }
                BigInteger n = BigInteger.Parse(nTxt.Text);
                BigInteger ex = BigInteger.Parse(eTxt.Text); // Pervadinta į ex nes maišosi su EventArgs e

                Cryption rsaWork = new Cryption();
                rsaWork.rsaDecryption(encText, n, ex);
                decryptedTxt.Text = rsaWork.Decryption();
                string createText = decryptedTxt.Text + Environment.NewLine;
                File.WriteAllText("C:\\Users\\Nedas\\OneDrive\\Stalinis kompiuteris\\Informacijos saugumas\\Informacijos_saugumas_praktinis_3\\Decrypted.txt", createText);

            }
        }
    }
}
