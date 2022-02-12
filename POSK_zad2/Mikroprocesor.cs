using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSK_zad1
{
    class Mikroprocesor
    {
        public static bool[] register = new bool[64]; //inicjalizacja miejsca na cztery 16 bitowe rejestry
        public static bool[] stos = new bool[16];

        //przypisanie adresów rejestru AX
        public const byte AH = 0;
        public const byte AL = 8;
        //przypisanie adresów rejestru BX
        public const byte BH = 16;
        public const byte BL = 24;
        //przypisanie adresów rejestru CX
        public const byte CH = 32;
        public const byte CL = 40;
        //przypisanie adresów rejestru DX
        public const byte DH = 48;
        public const byte DL = 56;

        public static bool ST = false; //flaga pracy krokowej
        private static bool OF = false; //flaga przepełnienia
        private static bool CF = false; //flaga przeniesienia

        public static bool full()
        {
            return OF;
        }


        public static string receivingTxt(byte address)
        {
            string buff = "";
            for (int i = 0; i < 8; i++)
            {            
                if (register[i + address])//Dopisanie 1 dla bitów "true"        
                {         
                    buff += "1";     
                }        
                else buff += "0";      
            }       
            return buff;
        }
        //Funkcja przesłania 
        //Tryb rejestrowy
        public static void MOV(byte RD, byte RS)
        {
            for (int i = 0; i < 16; i++)
            {
                register[i + RD] = register[i + RS];
            }
            OF = false;
        }
        //Tryb natychmiastowy
       public static void MOV(byte RD, bool[] L)
        {
            for (int i = 0; i < 16; i++)
            {
                register[i + RD] = L[i];
            }
            OF = false;
        }

        //Funkcja dodania
        public static void ADD(byte RD, byte RS)
        {
            for (int i = 0; i < 16; i++) //15; i >= 0; i--)
            {
                if (CF)
                {
                    if (register[i + RD] || register[i + RS]) //wyszukanie co najmniej jednej 1
                    {
                        if (register[i + RD] && register[i + RS]) //wyszukanie dwóch jedynek (1+1)
                        {
                            register[i + RD] = true; //1+1+1=11, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            register[i + RD] = false; //1+0+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                    }
                    else
                    {
                        register[i + RD] = true; //0+0+1=1, więc 1 (true) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
                else
                {
                    if (register[i + RD] || register[i + RS]) ///wyszukanie co najmniej jednej 1
                    {
                        if (register[i + RD] && register[i + RS]) //wyszukanie dwóch 1
                        {
                            register[i + RD] = false; //1+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            register[i + RD] = true; //1+0=1, więc 1 (true) wyniku i przeniesienie 0
                            CF = false;
                        }
                    }
                    else
                    {
                        register[i + RD] = false; //nie znaleziono żadnej 1 - 0+0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    register[i + RD] = true;
                }
            }
            else OF = false;
        }
        public static void ADD(byte RD, bool[] liczba)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (register[i + RD] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (register[i + RD] && liczba[i]) //gry 1+1
                        {
                            register[i + RD] = true; //1+1+1=11, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            register[i + RD] = false; //1+0+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                    }
                    else
                    {
                        register[i + RD] = true; //0+0+1=1, więc 1 (true) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
                else
                {
                    if (register[i + RD] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (register[i + RD] && liczba[i]) //gry 1+1
                        {
                            register[i + RD] = false; //1+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            register[i + RD] = true; //1+0=1, więc 1 (true) wyniku i przeniesienie 0
                            CF = false;
                        }
                    }
                    else
                    {
                        register[i + RD] = false; //0+0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    register[i + RD] = true;
                }
            }
            else OF = false;
        }

        //Funkcja odejmowania
        public static void SUB(byte RD, byte RS)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (register[i + RD] || register[i+RS]) //wyszukanie conajmniej jednej 1
                    {
                        if (register[i + RD] && register[i + RS]) //sprawdzenie dwóch 1
                        {
                            register[i + RD] = true; //10-1-1=1, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            if (register[i + RD])
                            {
                                register[i + RD] = false; //1-0-1=0, więc 0 (false) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                register[i + RD] = false; //10-1-1=0, więc 0 (false) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        register[i + RD] = true; //10-0-1=1, więc 1 (true) wyniku i przeniesienie 1
                        CF = true;
                    }
                }
                else
                {
                    if (register[i + RD] || register[i + RS]) //gdy jest chociaz jedna 1
                    {
                        if (register[i + RD] && register[i + RS]) //gry 1-1
                        {
                            register[i + RD] = false; //1-1=0, więc 0 (false) wyniku i przeniesienie 0
                            CF = false;
                        }
                        else
                        {
                            if (register[i + RD])
                            {
                                register[i + RD] = true; //1-0=1, więc 1 (true) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                register[i + RD] = true; //10-1=1, więc 1 (true) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        register[i + RD] = false; //0-0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    register[i + RD] = false;
                }
            }
            else OF = false;
        }

        public static void SUB(byte RD, bool[] liczba)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (register[i + RD] || liczba[i]) //wyszukanie conajmniej jednej 1
                    {
                        if (register[i + RD] && liczba[i]) //sprawdzenie dwóch 1
                        {
                            register[i + RD] = true; //10-1-1=1, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            if (register[i + RD])
                            {
                                register[i + RD] = false; //1-0-1=0, więc 0 (false) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                register[i + RD] = false; //10-1-1=0, więc 0 (false) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        register[i + RD] = true; //10-0-1=1, więc 1 (true) wyniku i przeniesienie 1
                        CF = true;
                    }
                }
                else
                {
                    if (register[i + RD] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (register[i + RD] && liczba[i]) //gry 1-1
                        {
                            register[i + RD] = false; //1-1=0, więc 0 (false) wyniku i przeniesienie 0
                            CF = false;
                        }
                        else
                        {
                            if (register[i + RD])
                            {
                                register[i + RD] = true; //1-0=1, więc 1 (true) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                register[i + RD] = true; //10-1=1, więc 1 (true) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        register[i + RD] = false; //0-0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    register[i + RD] = false;
                }
            }
            else OF = false;
        }
    }
}
