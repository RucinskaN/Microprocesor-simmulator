using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSK_zad1
{
    class TextControllClass
    {
        public static string TextControll(string textBoxValue)
        {
            if (textBoxValue.Length != 0)
            {
                string buff = "";

                for (int i = 0; i < textBoxValue.Length; i++)
                {
                    if (i < 16)
                    {
                        if (textBoxValue[i].Equals('1') || textBoxValue[i].Equals('0'))
                        {
                            buff += textBoxValue[i];
                        }
                    }
                }
                textBoxValue = buff;
            }
            return textBoxValue;
        }
        /*public static bool ToBolean(byte[] tab, int start)
        {

        } */
        public static bool charToBool(char bit)
        {
            if (bit.Equals('1')) return true;
            else return false;
        }
        public static bool[] textToNumber(string text)
        {
            bool[] temp = new bool[16];
            for (int i = 0; i < 16; i++)
            {
                if (i < text.Length) temp[15 - i] = charToBool(text[text.Length - 1 - i]);
                else temp[15 - i] = false;
            }
            return temp;
        }
    }
}
