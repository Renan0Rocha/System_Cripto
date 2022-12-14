//Alunos: Renan da Rocha Santos - Rafael Felipe de Oliveira Aguiar
using System;
using System.Windows;

namespace SystemCripto
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCriptografar_Click(object sender, RoutedEventArgs e)
        {
            

            for (int i = 0; i < Convert.ToInt32(txtMensagem.Text.Length); i++)
            {
                    string criptado = null;

                    if (txtMensagem.Text.Substring(i, 1) == " ")
                    {
                        criptado = "!";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }

                    if (txtMensagem.Text.Substring(i, 1) == "a")
                    {
                        criptado = "T";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "b")
                    {
                        criptado = "h";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "c")
                    {
                        criptado = "o";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "d")
                    {
                        criptado = "U";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "e")
                    {
                        criptado = "ç";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "f")
                    {
                        criptado = "L";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "g")
                    {
                        criptado = "y";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "h")
                    {
                        criptado = "R";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "i")
                    {
                        criptado = "7";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "j")
                    {
                        criptado = "w";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "k")
                    {
                        criptado = "A";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "l")
                    {
                        criptado = "Q";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "m")
                    {
                        criptado = "k";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "n")
                    {
                        criptado = "8";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "o")
                    {
                        criptado = "6";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "p")
                    {
                        criptado = "i";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "q")
                    {
                        criptado = "e";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "r")
                    {
                        criptado = "v";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "s")
                    {
                        criptado = "D";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "t")
                    {
                        criptado = "m";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "u")
                    {
                        criptado = "X";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "v")
                    {
                        criptado = "p";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "w")
                    {
                        criptado = "b";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "x")
                    {
                        criptado = "f";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "y")
                    {
                        criptado = "j";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "z")
                    {
                        criptado = "ú";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "ç")
                    {
                        criptado = "G";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Ç")
                    {
                        criptado = "S";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }

                    if (txtMensagem.Text.Substring(i, 1) == "A")
                    {
                        criptado = "t";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "B")
                    {
                        criptado = "H";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "C")
                    {
                        criptado = "O";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "D")
                    {
                        criptado = "u";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "E")
                    {
                        criptado = "Ç";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "F")
                    {
                        criptado = "l";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "G")
                    {
                        criptado = "Y";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "H")
                    {
                        criptado = "r";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "I")
                    {
                        criptado = "]";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "J")
                    {
                        criptado = "W";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "K")
                    {
                        criptado = "a";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "L")
                    {
                        criptado = "q";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "M")
                    {
                        criptado = "K";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "N")
                    {
                        criptado = "=";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "O")
                    {
                        criptado = ")";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "P")
                    {
                        criptado = "I";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Q")
                    {
                        criptado = "E";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "R")
                    {
                        criptado = "V";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "S")
                    {
                        criptado = "d";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "T")
                    {
                        criptado = "M";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "U")
                    {
                        criptado = "x";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "V")
                    {
                        criptado = "P";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "W")
                    {
                        criptado = "B";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "X")
                    {
                        criptado = "F";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Y")
                    {
                        criptado = "J";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Z")
                    {
                        criptado = ">";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }

                    if (txtMensagem.Text.Substring(i, 1) == "0")
                    {
                        criptado = "+";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "1")
                    {
                        criptado = "3";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "2")
                    {
                        criptado = "#";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "#")
                    {
                        criptado = "Û";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "3")
                    {
                        criptado = "*";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "4")
                    {
                        criptado = "9";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "5")
                    {
                        criptado = "&";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "6")
                    {
                        criptado = ",";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "7")
                    {
                        criptado = "c";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "8")
                    {
                        criptado = "g";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "9")
                    {
                        criptado = "@";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }

                    if (txtMensagem.Text.Substring(i, 1) == "!")
                    {
                        criptado = "$";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "?")
                    {
                        criptado = "Ó";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == ".")
                    {
                        criptado = "n";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "'")
                    {
                        criptado = "0";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "+")
                    {
                        criptado = "Ú";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == ",")
                    {
                        criptado = "?";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "=")
                    {
                        criptado = "N";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == ")")
                    {
                        criptado = "Ê";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "/")
                    {
                        criptado = "á";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == ">")
                    {
                        criptado = "÷";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "{")
                    {
                        criptado = "ã";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "}")
                    {
                        criptado = "õ";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "<")
                    {
                        criptado = "Á";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "^")
                    {
                        criptado = "é";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "%")
                    {
                        criptado = "¨";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "@")
                    {
                        criptado = "|";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "$")
                    {
                        criptado = "ï";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "-")
                    {
                        criptado = "ë";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "ã")
                    {
                        criptado = "{";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "õ")
                    {
                        criptado = "}";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "á")
                    {
                        criptado = "/";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "à")
                    {
                        criptado = "É";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "À")
                    {
                        criptado = "Ô";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "é")
                    {
                        criptado = "^";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "ó")
                    {
                        criptado = "1";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "í")
                    {
                        criptado = "4";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "ê")
                    {
                        criptado = "5";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "ô")
                    {
                        criptado = "z";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "ú")
                    {
                        criptado = "-";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Ã")
                    {
                        criptado = "í";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Õ")
                    {
                        criptado = "ê";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Á")
                    {
                        criptado = "<";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "É")
                    {
                        criptado = "C";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Ó")
                    {
                        criptado = "2";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Í")
                    {
                        criptado = "%";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Ê")
                    {
                        criptado = "Ô";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Ô")
                    {
                        criptado = "Z";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (txtMensagem.Text.Substring(i, 1) == "Ú")
                    {
                        criptado = "s";
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }
                    if (criptado == null)
                    {
                        criptado = txtMensagem.Text.Substring(i, 1);
                        txtCriptografia.Text = txtCriptografia.Text + criptado;
                    }

            }
            txtMensagem.Clear();
        }

        private void btDescriptografar_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < Convert.ToInt32(txtCriptografia.Text.Length); i++)
            {
                string criptado = null;

                if (txtCriptografia.Text.Substring(i, 1) == "T")
                {
                    criptado = "a";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "h")
                {
                    criptado = "b";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "o")
                {
                    criptado = "c";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "U")
                {
                    criptado = "d";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ç")
                {
                    criptado = "e";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "L")
                {
                    criptado = "f";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "y")
                {
                    criptado = "g";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "R")
                {
                    criptado = "h";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "7")
                {
                    criptado = "i";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "w")
                {
                    criptado = "j";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "A")
                {
                    criptado = "k";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Q")
                {
                    criptado = "l";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "k")
                {
                    criptado = "m";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "8")
                {
                    criptado = "n";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "6")
                {
                    criptado = "o";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "i")
                {
                    criptado = "p";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "e")
                {
                    criptado = "q";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "v")
                {
                    criptado = "r";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "D")
                {
                    criptado = "s";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "m")
                {
                    criptado = "t";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "X")
                {
                    criptado = "u";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "p")
                {
                    criptado = "v";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "b")
                {
                    criptado = "w";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "f")
                {
                    criptado = "x";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "j")
                {
                    criptado = "y";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ú")
                {
                    criptado = "z";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "t")
                {
                    criptado = "A";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "H")
                {
                    criptado = "B";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "O")
                {
                    criptado = "C";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "u")
                {
                    criptado = "D";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ç")
                {
                    criptado = "E";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "l")
                {
                    criptado = "F";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Y")
                {
                    criptado = "G";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "r")
                {
                    criptado = "H";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "]")
                {
                    criptado = "I";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "W")
                {
                    criptado = "J";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "a")
                {
                    criptado = "K";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "q")
                {
                    criptado = "L";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "K")
                {
                    criptado = "M";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "=")
                {
                    criptado = "N";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == ")")
                {
                    criptado = "O";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "I")
                {
                    criptado = "P";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "E")
                {
                    criptado = "Q";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "V")
                {
                    criptado = "R";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "d")
                {
                    criptado = "S";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "M")
                {
                    criptado = "T";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "x")
                {
                    criptado = "U";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "P")
                {
                    criptado = "V";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "B")
                {
                    criptado = "W";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "F")
                {
                    criptado = "X";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "J")
                {
                    criptado = "Y";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == ">")
                {
                    criptado = "Z";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "G")
                {
                    criptado = "ç";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "S")
                {
                    criptado = "Ç";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "+")
                {
                    criptado = "0";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "3")
                {
                    criptado = "1";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "#")
                {
                    criptado = "2";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "*")
                {
                    criptado = "3";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "9")
                {
                    criptado = "4";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "&")
                {
                    criptado = "5";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == ",")
                {
                    criptado = "6";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "c")
                {
                    criptado = "7";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "g")
                {
                    criptado = "8";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "@")
                {
                    criptado = "9";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "!")
                {
                    criptado = " ";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "$")
                {
                    criptado = "!";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ó")
                {
                    criptado = "?";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "n")
                {
                    criptado = ".";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "0")
                {
                    criptado = "'";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ú")
                {
                    criptado = "+";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "?")
                {
                    criptado = ",";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "N")
                {
                    criptado = "=";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ê")
                {
                    criptado = ")";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "÷")
                {
                    criptado = ">";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ã")
                {
                    criptado = "{";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "õ")
                {
                    criptado = "}";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "/")
                {
                    criptado = "á";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Á")
                {
                    criptado = "<";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "¨")
                {
                    criptado = "%";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "|")
                {
                    criptado = "@";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ë")
                {
                    criptado = "-";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Û")
                {
                    criptado = "#";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ï")
                {
                    criptado = "$";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "{")
                {
                    criptado = "ã";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "}")
                {
                    criptado = "õ";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "é")
                {
                    criptado = "á";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "^")
                {
                    criptado = "é";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "1")
                {
                    criptado = "ó";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "4")
                {
                    criptado = "í";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "5")
                {
                    criptado = "ê";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "z")
                {
                    criptado = "ô";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "-")
                {
                    criptado = "ú";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "É")
                {
                    criptado = "à";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }

                if (txtCriptografia.Text.Substring(i, 1) == "í")
                {
                    criptado = "Ã";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ê")
                {
                    criptado = "Õ";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "<")
                {
                    criptado = "Á";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "C")
                {
                    criptado = "É";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "2")
                {
                    criptado = "Ó";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "%")
                {
                    criptado = "Í";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ô")
                {
                    criptado = "À";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "s")
                {
                    criptado = "Ú";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "á")
                {
                    criptado = "/";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (criptado == null)
                {
                    criptado = txtCriptografia.Text.Substring(i, 1);
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
            }
            txtCriptografia.Clear();
        }
    }
}
