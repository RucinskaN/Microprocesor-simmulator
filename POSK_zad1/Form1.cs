using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            if (Mikroprocesor.ST) x = 1;
            else x = tasks;

            for (int i = 0; i < x; i++)
            {
                switch (task[i])
                {
                    case "MOV":
                        if (!cbStab[i]) Mikroprocesor.MOV(statList[i], optList[i]);
                        else Mikroprocesor.MOV(statList[i], stab[i]);
                        break;

                    case "ADD":
                        if (!cbStab[i]) Mikroprocesor.ADD(optList[i]);
                        else Mikroprocesor.ADD(stab[i]);
                        break;

                    case "SUB":
                        if (!cbStab[i]) Mikroprocesor.SUB(optList[i]);
                        else Mikroprocesor.SUB(stab[i]);
                        break;

                    default:
                        break;
                }
                switch (statList[i])
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
                case "MOV":
                    if (!cbStab[taskID]) Mikroprocesor.MOV(statList[taskID], optList[taskID]);
                    else Mikroprocesor.MOV(statList[taskID], stab[taskID]);
                    break;

                case "ADD":
                    if (!cbStab[taskID]) Mikroprocesor.ADD(optList[taskID]);
                    else Mikroprocesor.ADD(stab[taskID]);
                    break;
                case "SUB":
                    if (!cbStab[taskID]) Mikroprocesor.SUB(optList[taskID]);
                    else Mikroprocesor.SUB(stab[taskID]);
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

        private bool[] ToBoolean(bool[] vs, byte taskID)
        {
            throw new NotImplementedException();
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
    }
}
