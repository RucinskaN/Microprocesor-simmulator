using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace POSK_zad1
{
    public partial class Form1 : Form
    {
        static private bool cont = true;
        static private string[] task = new string[4];
        static private byte[] statList = new byte[4];
        static private byte[] optList = new byte[4];
        static private bool[][] stab = new bool[4][];
        static private bool[] cbStab = new bool[4];

        private static byte tasks = 0;
        private static byte taskID = 0;
        static public string[] save = new string[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Obsługa listboxów rozkazów
        private void lbRegister1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (lbRegister1.SelectedItem.ToString())
                {
                    case "MOV":
                        lbRecordStat1.Enabled = true;
                        lbRecordStat1.ClearSelected();
                        if (cbCheck1.Checked)
                        {
                            lbRecordOpt1.Enabled = false;
                            lbRecordOpt1.ClearSelected();
                            tbRecord1.Enabled = true;

                        }
                        else
                        {
                            lbRecordOpt1.Enabled = true;
                            lbRecordOpt1.ClearSelected();
                            tbRecord1.Enabled = false;
                        }
                        tbRecord1.Text = "0000000000000000";
                        cbCheck1.Enabled = true;
                        cbCheck1.Checked = false;
                        break;
                    case "ADD":
                        
                     lbRecordStat1.Enabled = true;
                     lbRecordStat1.ClearSelected();
                     if (cbCheck1.Checked)
                     {
                         lbRecordOpt1.Enabled = false;
                         lbRecordOpt1.ClearSelected();
                         tbRecord1.Enabled = true;

                     }
                     else
                     {
                         lbRecordOpt1.Enabled = true;
                         lbRecordOpt1.ClearSelected();
                         tbRecord1.Enabled = false;
                     }
                     tbRecord1.Text = "0000000000000000";
                     cbCheck1.Enabled = true;
                     cbCheck1.Checked = false;
                     break;
                    case "SUB":
                        lbRecordStat1.Enabled = true;
                        lbRecordStat1.ClearSelected();
                        if (cbCheck1.Checked)
                        {
                            lbRecordOpt1.Enabled = false;
                            lbRecordOpt1.ClearSelected();
                            tbRecord1.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt1.Enabled = true;
                            lbRecordOpt1.ClearSelected();
                            tbRecord1.Enabled = false;
                        }
                        tbRecord1.Text = "0000000000000000";
                        cbCheck1.Enabled = true;
                        cbCheck1.Checked = false;
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void lbRegister2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (lbRegister2.SelectedItem.ToString())
                {
                    case "MOV":
                        lbRecordStat2.Enabled = true;
                        lbRecordStat2.ClearSelected();
                        if (cbCheck2.Checked)
                        {
                            lbRecordOpt2.Enabled = false;
                            lbRecordOpt2.ClearSelected();
                            tbRecord2.Enabled = true;

                        }
                        else
                        {
                            lbRecordOpt2.Enabled = true;
                            lbRecordOpt2.ClearSelected();
                            tbRecord2.Enabled = false;
                        }
                        tbRecord2.Text = "0000000000000000";
                        cbCheck2.Enabled = true;
                        cbCheck2.Checked = false;
                        break;
                    case "ADD":
                        lbRecordStat2.Enabled = true;
                        lbRecordStat2.ClearSelected();
                        if (cbCheck2.Checked)
                        {
                            lbRecordOpt2.Enabled = false;
                            lbRecordOpt2.ClearSelected();
                            tbRecord2.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt2.Enabled = true;
                            lbRecordOpt2.ClearSelected();
                            tbRecord2.Enabled = false;
                        }
                        tbRecord2.Text = "0000000000000000";
                        cbCheck2.Enabled = true;
                        cbCheck2.Checked = false;
                        break;
                    case "SUB":
                        lbRecordStat2.Enabled = true;
                        lbRecordStat2.ClearSelected();
                        if (cbCheck2.Checked)
                        {
                            lbRecordOpt2.Enabled = false;
                            lbRecordOpt2.ClearSelected();
                            tbRecord2.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt2.Enabled = true;
                            lbRecordOpt2.ClearSelected();
                            tbRecord2.Enabled = false;
                        }
                        tbRecord2.Text = "0000000000000000";
                        cbCheck2.Enabled = true;
                        cbCheck2.Checked = false;
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void lbRegister3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (lbRegister3.SelectedItem.ToString())
                {
                    case "MOV":
                        lbRecordStat3.Enabled = true;
                        lbRecordStat3.ClearSelected();
                        if (cbCheck3.Checked)
                        {
                            lbRecordOpt3.Enabled = false;
                            lbRecordOpt3.ClearSelected();
                            tbRecord3.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt3.Enabled = true;
                            lbRecordOpt3.ClearSelected();
                            tbRecord3.Enabled = false;
                        }
                        tbRecord3.Text = "0000000000000000";
                        cbCheck3.Enabled = true;
                        cbCheck3.Checked = false;
                        break;
                    case "ADD":
                        lbRecordStat3.Enabled =true;
                        lbRecordStat3.ClearSelected();
                        if (cbCheck3.Checked)
                        {
                            lbRecordOpt3.Enabled = false;
                            lbRecordOpt3.ClearSelected();
                            tbRecord3.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt3.Enabled = true;
                            lbRecordOpt3.ClearSelected();
                            tbRecord3.Enabled = false;
                        }
                        tbRecord3.Text = "0000000000000000";
                        cbCheck3.Enabled = true;
                        cbCheck3.Checked = false;
                        break;
                    case "SUB":
                        lbRecordStat3.Enabled = true;
                        lbRecordStat3.ClearSelected();
                        if (cbCheck3.Checked)
                        {
                            lbRecordOpt3.Enabled = false;
                            lbRecordOpt3.ClearSelected();
                            tbRecord3.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt3.Enabled = true;
                            lbRecordOpt3.ClearSelected();
                            tbRecord3.Enabled = false;
                        }
                        tbRecord3.Text = "0000000000000000";
                        cbCheck3.Enabled = true;
                        cbCheck3.Checked = false;
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void lbRegister4_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                switch (lbRegister4.SelectedItem.ToString())
                {
                    case "MOV":
                        lbRecordStat4.Enabled = true;
                        lbRecordStat4.ClearSelected();
                        if (cbCheck4.Checked)
                        {
                            lbRecordOpt4.Enabled = false;
                            lbRecordOpt4.ClearSelected();
                            tbRecord4.Enabled = true;

                        }
                        else
                        {
                            lbRecordOpt4.Enabled = true;
                            lbRecordOpt4.ClearSelected();
                            tbRecord4.Enabled = false;
                        }
                        tbRecord4.Text = "0000000000000000";
                        cbCheck4.Enabled = true;
                        cbCheck4.Checked = false;
                        break;
                    case "ADD":
                        lbRecordStat4.Enabled = true;
                        lbRecordStat4.ClearSelected();
                        if (cbCheck4.Checked)
                        {
                            lbRecordOpt4.Enabled = false;
                            lbRecordOpt4.ClearSelected();
                            tbRecord4.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt4.Enabled = true;
                            lbRecordOpt4.ClearSelected();
                            tbRecord4.Enabled = false;
                        }
                        tbRecord4.Text = "0000000000000000";
                        cbCheck4.Enabled = true;
                        cbCheck4.Checked = false;
                        break;
                    case "SUB":
                        lbRecordStat4.Enabled = true;
                        lbRecordStat4.ClearSelected();
                        if (cbCheck4.Checked)
                        {
                            lbRecordOpt4.Enabled = false;
                            lbRecordOpt4.ClearSelected();
                            tbRecord4.Enabled = true;
                        }
                        else
                        {
                            lbRecordOpt4.Enabled = true;
                            lbRecordOpt4.ClearSelected();
                            tbRecord4.Enabled = false;
                        }
                        tbRecord4.Text = "0000000000000000";
                        cbCheck4.Enabled = true;
                        cbCheck4.Checked = false;
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
            textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
            textBox3.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BH);
            textBox4.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BL);
            textBox5.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CH);
            textBox6.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CL);
            textBox7.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DH);
            textBox8.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DL);
            tbRecord1.Text = "00000000";
            tbRecord2.Text = "00000000";
            tbRecord3.Text = "00000000";
            tbRecord4.Text = "00000000";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (listBox1.SelectedItem.ToString())
                {

                    //Zmiana położenie kursora
                    case "INT10H 02h":
                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie 10H funkcja 02) 
                        Mikroprocesor.register[4] = true;
                        Mikroprocesor.register[6] = true;
                        Mikroprocesor.register[14] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        MessageBox.Show("Kursor zostanie przesunięty");
                        this.Cursor = new Cursor(Cursor.Current.Handle);
                        Cursor.Position = new Point(Cursor.Position.X - 100, Cursor.Position.Y - 100);

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;


                    //Wyświetlenie współrzędnych kursora w momencie uruchomienia przerwania
                    case "INT10H 03h":
                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie 10H funkcja 03) 
                        Mikroprocesor.register[4] = true;
                        Mikroprocesor.register[6] = true;
                        Mikroprocesor.register[14] = true;
                        Mikroprocesor.register[15] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        float x = Cursor.Position.X;
                        float y = Cursor.Position.Y;

                        MessageBox.Show("Współrzędne kursora: " + x + " ," + y);

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;


                        //Zmiana kolorów
                    case "INT10H 0Bh":
                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie 10H funkcja 0Bh) 
                        Mikroprocesor.register[4] = true;
                        Mikroprocesor.register[6] = true;
                        Mikroprocesor.register[12] = true;
                        Mikroprocesor.register[14] = true;
                        Mikroprocesor.register[15] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        MessageBox.Show("Zmiana koloru tła okna");
                        BackColor = Color.Khaki;
                        textBox1.BackColor = Color.LightYellow;
                        textBox2.BackColor = Color.LightYellow;
                        textBox3.BackColor = Color.LightYellow;
                        textBox4.BackColor = Color.LightYellow;
                        textBox5.BackColor = Color.LightYellow;
                        textBox6.BackColor = Color.LightYellow;
                        textBox7.BackColor = Color.LightYellow;
                        textBox8.BackColor = Color.LightYellow;
                        tbOF1.BackColor = Color.LightYellow;
                        tbOF2.BackColor = Color.LightYellow;
                        tbOF3.BackColor = Color.LightYellow;
                        tbOF4.BackColor = Color.LightYellow;
                        tbRecord1.BackColor = Color.LightYellow;
                        tbRecord2.BackColor = Color.LightYellow;
                        tbRecord3.BackColor = Color.LightYellow;
                        tbRecord4.BackColor = Color.LightYellow;
                        cbRegister1.BackColor = Color.Yellow;
                        cbRegister2.BackColor = Color.Yellow;
                        cbRegister3.BackColor = Color.Yellow;
                        cbRegister4.BackColor = Color.Yellow;
                        button1.BackColor = Color.DarkKhaki;
                        button2.BackColor = Color.DarkKhaki;
                        button3.BackColor = Color.DarkKhaki;
                        button4.BackColor = Color.DarkKhaki;

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;


                        //Podanie pamięci podstawowej
                    case "INT12H":
                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie 12H) 
                        Mikroprocesor.register[4] = true;
                        Mikroprocesor.register[5] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        MessageBox.Show("Pamięć podstawowa mikroprocesora: 64 bity");

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;


                        //RESET rejestrów
                    case "INT13H 00h":

                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie  13H, funkcja 02h) 
                        Mikroprocesor.register[4] = true;
                        Mikroprocesor.register[5] = true;
                        Mikroprocesor.register[7] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        MessageBox.Show("Reset wartości rejestrów");

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }

                        for(int i=0; i<64; i++)
                        {
                            Mikroprocesor.register[i] = false;
                        }

                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        textBox3.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BH);
                        textBox4.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BL);
                        textBox5.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CH);
                        textBox6.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CL);
                        textBox7.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DH);
                        textBox8.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DL);
                        break;


                    //ODCZYTANIE SEKTORÓW
                    case "INT13H 02h":

                        String ax1 = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        String ax2 = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie  13H, funkcja 02h) 
                        Mikroprocesor.register[4] = true;
                        Mikroprocesor.register[5] = true;
                        Mikroprocesor.register[7] = true;
                        Mikroprocesor.register[14] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        String bx1 = Mikroprocesor.receivingTxt(Mikroprocesor.BH);
                        String bx2 = Mikroprocesor.receivingTxt(Mikroprocesor.BL);
                        String cx1 = Mikroprocesor.receivingTxt(Mikroprocesor.CH);
                        String cx2 = Mikroprocesor.receivingTxt(Mikroprocesor.CL);
                        String dx1 = Mikroprocesor.receivingTxt(Mikroprocesor.DH);
                        String dx2 = Mikroprocesor.receivingTxt(Mikroprocesor.DL);

                        MessageBox.Show("Sektory: \nAX: "+ax1+" "+ ax2+"\nBX: "+bx1+" "+bx2+"\nCX: "+cx1+" "+cx2+"\nDX: "+dx1+" "+dx2);

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;


                    //Zatrzymanie aplikacji na określoną liczbę milisekund - przerwanie 15h funkcja 86h, 
                    case "INT15H 86h":
                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie  15H, funkcja 86h) 
                        for (int i=4; i<8; i++)
                        {
                            Mikroprocesor.register[i] = true;
                        }
                        
                        Mikroprocesor.register[9] = true;
                        Mikroprocesor.register[11] = true;
                        Mikroprocesor.register[13] = true;
                        Mikroprocesor.register[14] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        MessageBox.Show("Zatrzymanie aplikacji na 5 sekund");
                        Thread.Sleep(5000);

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;


                    //Sprawdzenie stanu klawiszów przełączających - SHIFT, ALT, CONTROL
                    case "INT16H 10h":
                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie  16, funkcja 10) 
                        Mikroprocesor.register[3] = true;
                        Mikroprocesor.register[12] = true;
                        Mikroprocesor.register[14] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift || (Control.ModifierKeys & Keys.Alt) == Keys.Alt || (Control.ModifierKeys & Keys.Control) == Keys.Control)
                        {
                            if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                            {
                                MessageBox.Show("KeyPress " + Keys.Alt);
                            }
                            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                            {
                                MessageBox.Show("KeyPress " + Keys.Shift);
                            }
                            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                            {
                                MessageBox.Show("KeyPress " + Keys.Control);
                            }
                        }
                        else
                        {
                            MessageBox.Show("None Key Pressed ");
                        }
                        //Wpisanie wartości rejestrów przed przerwaniem
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;

                        //Podanie daty
                    case "INT1AH 04h":

                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie  13H, funkcja 02h) 
                        Mikroprocesor.register[1] = true;
                        Mikroprocesor.register[2] = true;
                        for(int i=4; i<8; i++)
                        {
                            Mikroprocesor.register[i] = true;
                        }
                        Mikroprocesor.register[13] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);

                        
                        MessageBox.Show("Data: "+ DateTime.Now.Day+"." +DateTime.Now.Month+"." +DateTime.Now.Year);

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;


                    //Ustawienie daty 
                    case "INT1AH 05h":

                        //Zapis i zerowanie rejestru AX
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.stos[i] = Mikroprocesor.register[i];
                            Mikroprocesor.register[i] = false;
                        }
                        //Wpisanie numeru przerwania do rejestru AX (przerwanie  13H, funkcja 02h) 
                        Mikroprocesor.register[1] = true;
                        Mikroprocesor.register[2] = true;
                        for (int i = 4; i < 8; i++)
                        {
                            Mikroprocesor.register[i] = true;
                        }
                        Mikroprocesor.register[13] = true;
                        Mikroprocesor.register[15] = true;
                        //Wyświetlenie rejestrów przerwania
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);


                        MessageBox.Show("Data po dodaniu 35 dni: " + DateTime.Now.AddDays(35));

                        //Wpisanie wartości rejestrów przed przerwaniem i zerowanie stosu
                        for (int i = 0; i < 16; i++)
                        {
                            Mikroprocesor.register[i] = Mikroprocesor.stos[i];
                            Mikroprocesor.stos[i] = false;
                        }
                        //Wyświetlenie wartości rejestrów
                        textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
                        textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
                        break;
                }

            }
            catch (NullReferenceException)
            {

            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
                textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
            
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BH);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BL);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CH);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CL);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DH);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DL);
        }

        //Check boxy rozkazów

        private void cbRegister1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRegister2.Enabled)
            {
                cbRegister2.Enabled = true;
                cbRegister2.Checked = false;
            }
            else
            {
                cbRegister2.Enabled = true;
            }
            if (cbCheck1.Enabled)
            {
                cbCheck1.Enabled = false;
                cbCheck1.Checked = false;
            }
            else
            {
                cbCheck1.Enabled = true;
            }
            if (button1.Enabled)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            if (lbRegister1.Enabled)
            {
                lbRegister1.Enabled = false;
                lbRecordStat1.Enabled = false;
                lbRecordOpt1.Enabled = false;
                tbRecord1.Enabled = false;
                lbRegister1.ClearSelected();
                lbRecordStat1.ClearSelected();
                lbRecordOpt1.ClearSelected();
                tbRecord1.Text = "00000000";
            }
            else
            {
                lbRegister1.Enabled = true;
                lbRegister1.SelectedIndex = 0;
            }
        }

        private void cbRegister2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRegister3.Enabled)
            {
                cbRegister3.Enabled = true;
                cbRegister3.Checked = false;
            }
            else
            {
                cbRegister3.Enabled = true;
            }
            if (cbCheck2.Enabled)
            {
                cbCheck2.Enabled = false;
                cbCheck2.Checked = false;
            }
            else
            {
                cbCheck2.Enabled = true;
            }
            if (lbRegister2.Enabled)
            {
                lbRegister2.Enabled = false;
                lbRecordStat2.Enabled = false;
                lbRecordOpt2.Enabled = false;
                tbRecord2.Enabled = false;
                lbRegister2.ClearSelected();
                lbRecordStat2.ClearSelected();
                lbRecordOpt2.ClearSelected();
                tbRecord2.Text = "00000000";
            }
            else
            {
                lbRegister2.Enabled = true;
                lbRegister2.SelectedIndex = 0;
            }
        }

        private void cbRegister3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRegister4.Enabled)
            {
                cbRegister4.Enabled = true;
                cbRegister4.Checked = false;
            }
            else
            {
                cbRegister4.Enabled = true;
            }
            if (cbCheck3.Enabled)
            {
                cbCheck3.Enabled = false;
                cbCheck3.Checked = false;
            }
            else
            {
                cbCheck3.Enabled = true;
            }
            if (lbRegister3.Enabled)
            {
                lbRegister3.Enabled = false;
                lbRecordStat3.Enabled = false;
                lbRecordOpt3.Enabled = false;
                tbRecord3.Enabled = false;
                lbRegister3.ClearSelected();
                lbRecordStat3.ClearSelected();
                lbRecordOpt3.ClearSelected();
                tbRecord3.Text = "00000000";
            }
            else
            {
                lbRegister3.Enabled = true;
                lbRegister3.SelectedIndex = 0;
            }
        }

        private void cbRegister4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheck4.Enabled)
            {
                cbCheck4.Enabled = false;
                cbCheck4.Checked = false;
            }
            else
            {
                cbCheck4.Enabled = true;
            }
            if (lbRegister4.Enabled)
            {
                lbRegister4.Enabled = false;
                lbRecordStat4.Enabled = false;
                lbRecordOpt4.Enabled = false;
                tbRecord4.Enabled = false;
                lbRegister4.ClearSelected();
                lbRecordStat4.ClearSelected();
                lbRecordOpt4.ClearSelected();
                tbRecord4.Text = "00000000";
            }
            else
            {
                lbRegister4.Enabled = true;
                lbRegister4.SelectedIndex = 0;
            }
        }


        //check boxy trybu natychmiastowego:

        private void cbCheck1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (lbRecordOpt1.Enabled)
            {
                lbRecordOpt1.Enabled = false;
                lbRecordOpt1.ClearSelected();
                tbRecord1.Enabled = true;


            }
            else
            {
                lbRecordOpt1.Enabled = true;
                lbRecordOpt1.SelectedIndex = 0;
                tbRecord1.Text = "00000000";
                tbRecord1.Enabled = false;

            }
        }

        private void cbCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (lbRecordOpt2.Enabled)
            {
                lbRecordOpt2.Enabled = false;
                lbRecordOpt2.ClearSelected();
                tbRecord2.Enabled = true;

            }
            else
            {
                lbRecordOpt2.Enabled = true;
                lbRecordOpt2.SelectedIndex = 0;
                tbRecord2.Text = "00000000";
                tbRecord2.Enabled = false;
            }
        }

        private void cbCheck3_CheckedChanged(object sender, EventArgs e)
        {
            if (lbRecordOpt3.Enabled)
            {
                lbRecordOpt3.Enabled = false;
                lbRecordOpt3.ClearSelected();
                tbRecord3.Enabled = true;

            }
            else
            {
                lbRecordOpt3.Enabled = true;
                lbRecordOpt3.SelectedIndex = 0;
                tbRecord3.Text = "00000000";
                tbRecord3.Enabled = false;
            }
        }

        private void cbCheck4_CheckedChanged(object sender, EventArgs e)
        {
            if (lbRecordOpt4.Enabled)
            {
                lbRecordOpt4.Enabled = false;
                lbRecordOpt4.ClearSelected();
                tbRecord4.Enabled = true;

            }
            else
            {
                lbRecordOpt4.Enabled = true;
                lbRecordOpt4.SelectedIndex = 0;
                tbRecord4.Text = "00000000";
                tbRecord4.Enabled = false;
            }
        }

        //Text box trybu natychmiastowego
        private void tbRecord1_TextChanged(object sender, EventArgs e)
        {
            tbRecord1.Text = TextControllClass.TextControll(tbRecord1.Text);
        }

        private void tbRecord2_TextChanged(object sender, EventArgs e)
        {
            tbRecord2.Text = TextControllClass.TextControll(tbRecord2.Text);
        }

        private void tbRecord3_TextChanged(object sender, EventArgs e)
        {
            tbRecord3.Text = TextControllClass.TextControll(tbRecord3.Text);
        }

        private void tbRecord4_TextChanged(object sender, EventArgs e)
        {
            tbRecord4.Text = TextControllClass.TextControll(tbRecord4.Text);
        }

        //Przycisk start
        private void button1_Click(object sender, EventArgs e)
        {
            PK.Enabled = false;
            cbRegister1.Enabled = false;

            if (Mikroprocesor.ST) button2.Enabled = true;
            else button2.Enabled = false;

            tasks = 0;
            taskID = 0;

            for (int i = 0; i < 4; i++)
            {
                task[i] = "";
                statList[i] = 0;
                optList[i] = 0;
                stab[i] = new bool[8];
            }

            //Wybór 1 chceck box rozkazu
            if (cbRegister1.Checked)
            {
                tasks++;

                task[0] = lbRegister1.SelectedItem.ToString();
               if (task[0].Equals("MOV"))
                {
                    if (lbRecordStat1.SelectedItem.ToString().Equals("AX"))
                    {
                        statList[0] = Mikroprocesor.AH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("BX"))
                    {
                        statList[0] = Mikroprocesor.BH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("CX"))
                    {
                        statList[0] = Mikroprocesor.CH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("DX"))
                    {
                        statList[0] = Mikroprocesor.DH;
                    }
                }
                if (task[0].Equals("ADD"))
                {
                    if (lbRecordStat1.SelectedItem.ToString().Equals("AX"))
                    {
                        statList[0] = Mikroprocesor.AH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("BX"))
                    {
                        statList[0] = Mikroprocesor.BH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("CX"))
                    {
                        statList[0] = Mikroprocesor.CH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("DX"))
                    {
                        statList[0] = Mikroprocesor.DH;
                    }
                }
                if (task[0].Equals("SUB"))
                {
                    if (lbRecordStat1.SelectedItem.ToString().Equals("AX"))
                    {
                        statList[0] = Mikroprocesor.AH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("BX"))
                    {
                        statList[0] = Mikroprocesor.BH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("CX"))
                    {
                        statList[0] = Mikroprocesor.CH;
                    }
                    else if (lbRecordStat1.SelectedItem.ToString().Equals("DX"))
                    {
                        statList[0] = Mikroprocesor.DH;
                    }
                }

                if (!cbCheck1.Checked)
                {

                    if (lbRecordOpt1.SelectedItem.ToString().Equals("AX"))
                    {
                        optList[0] = Mikroprocesor.AH;

                    }
                    if (lbRecordOpt1.SelectedItem.ToString().Equals("BX"))
                    {
                        optList[0] = Mikroprocesor.BH;
                    }
                    if (lbRecordOpt1.SelectedItem.ToString().Equals("CX"))
                    {
                        optList[0] = Mikroprocesor.CH;
                    }
                    if (lbRecordOpt1.SelectedItem.ToString().Equals("DX"))
                    {
                        optList[0] = Mikroprocesor.DH;
                    }
                }
                else
                {
                    stab[0] = TextControllClass.textToNumber(tbRecord1.Text);
                }

                //Wybór 2 chceck box rozkazu
                if (cbRegister2.Checked)
                {
                    tasks++;
                    task[1] = lbRegister2.SelectedItem.ToString();
                    if (task[1].Equals("MOV"))
                    {
                        if (lbRecordStat2.SelectedItem.ToString().Equals("AX"))
                        {
                            statList[1] = Mikroprocesor.AH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("BX"))
                        {
                            statList[1] = Mikroprocesor.BH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("CX"))
                        {
                            statList[1] = Mikroprocesor.CH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("DX"))
                        {
                            statList[1] = Mikroprocesor.DH;
                        }

                    }
                    if (task[1].Equals("ADD"))
                    {
                        if (lbRecordStat2.SelectedItem.ToString().Equals("AX"))
                        {
                            statList[1] = Mikroprocesor.AH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("BX"))
                        {
                            statList[1] = Mikroprocesor.BH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("CX"))
                        {
                            statList[1] = Mikroprocesor.CH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("DX"))
                        {
                            statList[1] = Mikroprocesor.DH;
                        }

                    }
                    if (task[1].Equals("SUB"))
                    {
                        if (lbRecordStat2.SelectedItem.ToString().Equals("AX"))
                        {
                            statList[1] = Mikroprocesor.AH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("BX"))
                        {
                            statList[1] = Mikroprocesor.BH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("CX"))
                        {
                            statList[1] = Mikroprocesor.CH;
                        }
                        if (lbRecordStat2.SelectedItem.ToString().Equals("DX"))
                        {
                            statList[1] = Mikroprocesor.DH;
                        }

                    }

                    if (!cbCheck2.Checked)
                    {
                        if (lbRecordOpt2.SelectedItem.ToString().Equals("AX"))
                        {
                            optList[1] = Mikroprocesor.AH;
                        }
                        else if (lbRecordOpt2.SelectedItem.ToString().Equals("BX"))
                        {
                            optList[1] = Mikroprocesor.BH;
                        }
                        else if (lbRecordOpt2.SelectedItem.ToString().Equals("CX"))
                        {
                            optList[1] = Mikroprocesor.CH;
                        }
                        else if (lbRecordOpt2.SelectedItem.ToString().Equals("DX"))
                        {
                            optList[1] = Mikroprocesor.DH;
                        }
                    }
                    else
                    {
                        stab[1] = TextControllClass.textToNumber(tbRecord2.Text);
                    }

                    //Wybór 3 chceck box rozkazu
                    if (cbRegister3.Checked)
                    {
                        tasks++;
                        task[2] = lbRegister3.SelectedItem.ToString();
                        if (task[2].Equals("MOV"))
                        {
                            if (lbRecordStat3.SelectedItem.ToString().Equals("AX"))
                            {
                                statList[2] = Mikroprocesor.AH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("BX"))
                            {
                                statList[2] = Mikroprocesor.BH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("CX"))
                            {
                                statList[2] = Mikroprocesor.CH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("DX"))
                            {
                                statList[2] = Mikroprocesor.DH;
                            }
                        }
                        if (task[2].Equals("ADD"))
                        {
                            if (lbRecordStat3.SelectedItem.ToString().Equals("AX"))
                            {
                                statList[2] = Mikroprocesor.AH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("BX"))
                            {
                                statList[2] = Mikroprocesor.BH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("CX"))
                            {
                                statList[2] = Mikroprocesor.CH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("DX"))
                            {
                                statList[2] = Mikroprocesor.DH;
                            }
                        }
                        if (task[2].Equals("SUB"))
                        {
                            if (lbRecordStat3.SelectedItem.ToString().Equals("AX"))
                            {
                                statList[2] = Mikroprocesor.AH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("BX"))
                            {
                                statList[2] = Mikroprocesor.BH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("CX"))
                            {
                                statList[2] = Mikroprocesor.CH;
                            }
                            if (lbRecordStat3.SelectedItem.ToString().Equals("DX"))
                            {
                                statList[2] = Mikroprocesor.DH;
                            }
                        }

                        if (!cbCheck3.Checked)
                        {
                            if (lbRecordOpt3.SelectedItem.ToString().Equals("AX"))
                            {
                                optList[2] = Mikroprocesor.AH;
                            }
                            if (lbRecordOpt3.SelectedItem.ToString().Equals("BX"))
                            {
                                optList[2] = Mikroprocesor.BH;
                            }
                            if (lbRecordOpt3.SelectedItem.ToString().Equals("CX"))
                            {
                                optList[2] = Mikroprocesor.CH;
                            }
                            if (lbRecordOpt3.SelectedItem.ToString().Equals("DX"))
                            {
                                optList[2] = Mikroprocesor.DH;
                            }
                        }
                        else
                        {
                            stab[2] = TextControllClass.textToNumber(tbRecord3.Text);
                        }

                        //Wybór 4 chceck box rozkazu
                        if (cbRegister4.Checked)
                        {
                            tasks++;
                            task[3] = lbRegister4.SelectedItem.ToString();
                            if (task[3].Equals("MOV"))
                            {
                                if (lbRecordStat4.SelectedItem.ToString().Equals("AX"))
                                {
                                    statList[3] = Mikroprocesor.AH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("BX"))
                                {
                                    statList[3] = Mikroprocesor.BH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("CX"))
                                {
                                    statList[3] = Mikroprocesor.CH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("DX"))
                                {
                                    statList[3] = Mikroprocesor.DH;
                                }
                            }
                            if (task[3].Equals("ADD"))
                            {
                                if (lbRecordStat4.SelectedItem.ToString().Equals("AX"))
                                {
                                    statList[3] = Mikroprocesor.AH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("BX"))
                                {
                                    statList[3] = Mikroprocesor.BH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("CX"))
                                {
                                    statList[3] = Mikroprocesor.CH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("DX"))
                                {
                                    statList[3] = Mikroprocesor.DH;
                                }
                            }
                            if (task[3].Equals("SUB"))
                            {
                                if (lbRecordStat4.SelectedItem.ToString().Equals("AX"))
                                {
                                    statList[3] = Mikroprocesor.AH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("BX"))
                                {
                                    statList[3] = Mikroprocesor.BH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("CX"))
                                {
                                    statList[3] = Mikroprocesor.CH;
                                }
                                if (lbRecordStat4.SelectedItem.ToString().Equals("DX"))
                                {
                                    statList[3] = Mikroprocesor.DH;
                                }
                            }

                            if (!cbCheck4.Checked)
                            {
                                if (lbRecordOpt4.SelectedItem.ToString().Equals("AX"))
                                {
                                    optList[3] = Mikroprocesor.AH;
                                }
                                if (lbRecordOpt4.SelectedItem.ToString().Equals("BX"))
                                {
                                    optList[3] = Mikroprocesor.BH;
                                }
                                if (lbRecordOpt4.SelectedItem.ToString().Equals("CX"))
                                {
                                    optList[3] = Mikroprocesor.CH;
                                }
                                if (lbRecordOpt4.SelectedItem.ToString().Equals("DX"))
                                {
                                    optList[3] = Mikroprocesor.DH;
                                }
                            }
                            else
                            {
                                stab[3] = TextControllClass.textToNumber(tbRecord4.Text);
                            }
                        }
                    }
                }
            }
            cbStab[0] = cbCheck1.Checked;
            cbStab[1] = cbCheck2.Checked;
            cbStab[2] = cbCheck3.Checked;
            cbStab[3] = cbCheck4.Checked;

            int x = 0;
            if (Mikroprocesor.ST) x = 1; //Sprawdzenie czy została włączona funkcja pracy krokowej
            else x = tasks; //Bez pracy krokowej wyniki wszystkich rozkazów zostaną pokazane jednocześnie

            for (int i = 0; i < x; i++)
            {
                switch (task[i])
                {
                    // Wywołanie odpowiedniej metody mikroprocesora w zależności od wybranego rozkazu
                    case "MOV":
                        if (!cbStab[i]) Mikroprocesor.MOV(statList[i], optList[i]);
                        else Mikroprocesor.MOV(statList[i], stab[i]);
                        break;

                    case "ADD":
                        if (!cbStab[i]) Mikroprocesor.ADD(statList[taskID], optList[i]);
                        else Mikroprocesor.ADD(statList[taskID], stab[i]);
                        break;

                    case "SUB":
                        if (!cbStab[i]) Mikroprocesor.SUB(statList[taskID], optList[i]);
                        else Mikroprocesor.SUB(statList[taskID], stab[i]);
                        break;

                    default:
                        break;
                }
                switch (statList[i])
                {
                    //Obsługa flag przepełnienia - OF
                    case Mikroprocesor.AH:
                        if (Mikroprocesor.full()) tbOF1.Text = "1";
                        else tbOF1.Text = "0";
                        break;

                    case Mikroprocesor.BH:
                        if (Mikroprocesor.full()) tbOF2.Text = "1";
                        else tbOF2.Text = "0";
                        break;

                    case Mikroprocesor.CH:
                        if (Mikroprocesor.full()) tbOF3.Text = "1";
                        else tbOF3.Text = "0";
                        break;
                    case Mikroprocesor.DH:
                        if (Mikroprocesor.full()) tbOF4.Text = "1";
                        else tbOF4.Text = "0";
                        break;
                    default:
                        break;
                }

                taskID++;
            }


            //Przypisanie wartości dla textboxów pokazujących stan rejestrów
            textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
            textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
            textBox3.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BH);
            textBox4.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BL);
            textBox5.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CH);
            textBox6.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CL);
            textBox7.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DH);
            textBox8.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DL);

            tbRecord1.Text = "00000000";
            tbRecord2.Text = "00000000";
            tbRecord3.Text = "00000000";
            tbRecord4.Text = "00000000";
            cbRegister1.Checked = false;

            if (!Mikroprocesor.ST)
            {
                PK.Checked = false;
                button2.Enabled = false;
                cbRegister1.Enabled = true;
                PK.Enabled = true;
            }
        }
        //Przycisk dalej
        private void button2_Click(object sender, EventArgs e)
        {
            switch (task[taskID])
            {
                //Wybór rozkazu
                case "MOV":
                    if (!cbStab[taskID]) Mikroprocesor.MOV(statList[taskID], optList[taskID]);
                    else Mikroprocesor.MOV(statList[taskID], stab[taskID]);
                    break;

                case "ADD":
                    if (!cbStab[taskID]) Mikroprocesor.ADD(statList[taskID], optList[taskID]);
                    else Mikroprocesor.ADD(statList[taskID], stab[taskID]);
                    break;
                case "SUB":
                    if (!cbStab[taskID]) Mikroprocesor.SUB(statList[taskID], optList[taskID]);
                    else Mikroprocesor.SUB(statList[taskID], stab[taskID]);
                    break;

                default:
                    break;
            }
            switch (statList[taskID])
            {
                case Mikroprocesor.AH:
                    if (Mikroprocesor.full()) tbOF1.Text = "1";
                    else tbOF1.Text = "0";
                    break;

                case Mikroprocesor.BH:
                    if (Mikroprocesor.full()) tbOF2.Text = "1";
                    else tbOF2.Text = "0";
                    break;

                case Mikroprocesor.CH:
                    if (Mikroprocesor.full()) tbOF3.Text = "1";
                    else tbOF3.Text = "0";
                    break;
                case Mikroprocesor.DH:
                    if (Mikroprocesor.full()) tbOF4.Text = "1";
                    else tbOF4.Text = "0";
                    break;
                default:
                    break;
            }
            taskID++;
            if (taskID >= tasks)
            {
                taskID = 0;
                tasks = 0;
                PK.Checked = false;
                button2.Enabled = false;
                cbRegister1.Enabled = true;
                PK.Enabled = true;
            }

            textBox1.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AH);
            textBox2.Text = Mikroprocesor.receivingTxt(Mikroprocesor.AL);
            textBox3.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BH);
            textBox4.Text = Mikroprocesor.receivingTxt(Mikroprocesor.BL);
            textBox5.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CH);
            textBox6.Text = Mikroprocesor.receivingTxt(Mikroprocesor.CL);
            textBox7.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DH);
            textBox8.Text = Mikroprocesor.receivingTxt(Mikroprocesor.DL);
            tbRecord1.Text = "00000000";
            tbRecord2.Text = "00000000";
            tbRecord3.Text = "00000000";
            tbRecord4.Text = "00000000";
            cbRegister1.Checked = false;
        }

        //Praca krokowa
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Mikroprocesor.ST)
            {
                Mikroprocesor.ST = false;
            }
            else
            {
                Mikroprocesor.ST = true;
            }
        }

        private void lbRecordStat1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Metoda zapisu do pliku 
        private void button3_Click(object sender, EventArgs e)
        {
            
            save[0] = textBox1.Text;
            save[1] = textBox2.Text;
            save[2] = textBox3.Text;
            save[3] = textBox4.Text;
            save[4] = textBox5.Text;
            save[5] = textBox6.Text;
            save[6] = textBox7.Text;
            save[7] = textBox8.Text;

            FileStream fs = new FileStream("zapis.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for(int i =0; i<8; i++)
            {
               // fs.WriteByte(save[i]);
            }
            fs.Close();
            Console.Read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
