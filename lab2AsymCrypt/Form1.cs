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
using System.Globalization;



namespace lab2AsymCrypt
{
    public partial class Form1 : Form
    {
        RSA bob;
        RSA alice;
        BigInteger Message;
        public Form1()
        {
            InitializeComponent();
            RSA bob = new RSA();
            RSA alice = new RSA();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bob = new RSA();
            alice = new RSA();

            Int32 length = Int32.Parse(lengthBox.Text);
            bob.generateKeys(length);
            alice.generateKeys(length);


            aliceN.Text = alice.N.ToString("X");
            aliceE.Text = alice.E.ToString("X");
            aliceD.Text = alice.D.ToString("X");

            bobN.Text = bob.N.ToString("X");
            bobE.Text = bob.E.ToString("X");
            bobD.Text = bob.D.ToString("X");



            lengthBox.Visible = false;
            button1.Visible = false;
            lenghtLabel.Visible = false;

            M.Visible = true;
            getM.Visible = true;
            CipherText.Visible = true;
            C.Visible = true;
            decryptBob.Visible = true;
            decryptAlice.Visible = true;
            OpenText.Visible = true;
            MForSignature.Visible = true;
            S.Visible = true;
            signAlice.Visible = true;
            signBob.Visible = true;
            verifyAlice.Visible = true;
            verifyBob.Visible = true;

            kBox.Visible = true;
            generateK.Visible = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BigInteger length = 0;
                if (lengthBox.Text != "")
                    length = BigInteger.Parse(lengthBox.Text);
                if (length <= 256 && length >= 128)
                    button1.Visible = true;
                else
                {
                    button1.Visible = false;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No correct format!");
            }
        }

        private void getM_Click(object sender, EventArgs e)
        {

            Message = GeneratorBigInteger.noFixedGenerateNumber(133);
            M.Text = Message.ToString("X");

            encryptBob.Visible = true;
            encryptAlice.Visible = true;

        }

        private void encryptBob_Click(object sender, EventArgs e)
        {
            if (Message != 0)
            {
                BigInteger C = bob.Encrypt(Message);
                CipherText.Text = C.ToString("X");
            }
        }

        private void encryptAlice_Click(object sender, EventArgs e)
        {
            if (Message != 0)
            {
                BigInteger C = alice.Encrypt(Message);
                CipherText.Text = C.ToString("X");
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void decryptBob_Click(object sender, EventArgs e)
        {
            if (C.Text != "")
            {
                BigInteger cipher = BigInteger.Parse(C.Text, NumberStyles.HexNumber);
                OpenText.Text = bob.Decrypt(cipher).ToString("X");
            }
        }

        private void decryptAlice_Click(object sender, EventArgs e)
        {
            if (C.Text != "")
            {
                BigInteger cipher = BigInteger.Parse(C.Text, NumberStyles.HexNumber);
                OpenText.Text = alice.Decrypt(cipher).ToString("X");
            }

        }

        private void M_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Message = BigInteger.Parse(M.Text, NumberStyles.HexNumber);
                encryptBob.Visible = true;
                encryptAlice.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("No correct format!");
            }
        }

        private void singBob_Click(object sender, EventArgs e)
        {
            if (MForSignature.Text != "")
            {
                BigInteger M = BigInteger.Parse(MForSignature.Text, NumberStyles.HexNumber);
                S.Text = bob.Decrypt(M).ToString("X");
            }
        }

        private void signAlice_Click(object sender, EventArgs e)
        {
            if (MForSignature.Text != "")
            {
                BigInteger M = BigInteger.Parse(MForSignature.Text, NumberStyles.HexNumber);
                S.Text = alice.Decrypt(M).ToString("X");
            }
        }



        private void verifyBob_Click(object sender, EventArgs e)
        {
            BigInteger M = BigInteger.Parse(MForSignature.Text, NumberStyles.HexNumber);
            BigInteger Signature = BigInteger.Parse(S.Text, NumberStyles.HexNumber);
            BigInteger _M = bob.Encrypt(Signature);
            if (M == _M)
            {
                verificationBob.ForeColor = Color.FromName("Blue");
                verificationBob.Text = "True";
                verificationBob.Visible = true;

            }
            else
            {
                verificationBob.ForeColor = Color.FromName("Red");
                verificationBob.Text = "False";
                verificationBob.Visible = true;
            }
        }

        private void verifyAlice_Click(object sender, EventArgs e)
        {
            BigInteger M = BigInteger.Parse(MForSignature.Text, NumberStyles.HexNumber);
            BigInteger Signature = BigInteger.Parse(S.Text, NumberStyles.HexNumber);
            BigInteger _M = alice.Encrypt(Signature);
            if (M == _M)
            {
                verificationAlice.ForeColor = Color.FromName("Blue");
                verificationAlice.Text = "True";
                verificationAlice.Visible = true;
            }

            else
            {
                verificationAlice.ForeColor = Color.FromName("Red");
                verificationAlice.Text = "False";
                verificationAlice.Visible = true;
            }
        }

        private void generateK_Click(object sender, EventArgs e)
        {
            if (bob.N > alice.N)
            {
                B.Text = "Bob";
                A.Text = "Alice";
            }
            else
            {
                B.Text = "Alice";
                A.Text = "Bob";
            }

            kBox.Text = GeneratorBigInteger.noFixedGenerateNumber(128).ToString("X");


            kBox1.Visible = true;
            kBox2.Visible = true;
            k1Box.Visible = true;
            SBox.Visible = true;
            SBox1.Visible = true;
            S1Box.Visible = true;
            generateK.Visible = false;
            sendK.Visible = true;
        }

        private void sendK_Click(object sender, EventArgs e)
        {
            RSA N1, N;
            BigInteger k, k1, S, S1;

            if (bob.N > alice.N)
            {
                N1 = bob;
                N = alice;
            }
            else
            {
                N1 = alice;
                N = bob;
            }

            k = BigInteger.Parse(kBox.Text, NumberStyles.HexNumber);
            k1 = N1.Encrypt(k);
            S = N.Decrypt(k);
            S1 = N1.Encrypt(S);

            k1Box.Text = k1.ToString("X");
            SBox.Text = S.ToString("X");
            S1Box.Text = S1.ToString("X");

            k = N1.Decrypt(k1);
            S = N1.Decrypt(S1);

            kBox1.Text = k.ToString("X");
            SBox1.Text = S.ToString("X");

            k = N.Encrypt(S);

            kBox2.Text = k.ToString("X");


        }


    }
}
