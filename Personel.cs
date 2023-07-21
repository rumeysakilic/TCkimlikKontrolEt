using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeveKontrol
{
    public class Personel
    {
        private string tcKimlikNo;
        public string TCKIMLIKNO
        {
            get
            {
                return tcKimlikNo.Substring(0,5)+ "******";
            }
            set
            {
                bool kontrolEt = false;
                if (value.Length== 11)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = Char.IsNumber( value[i] );
                        if ( sayiMi )
                        {
                            tcKimlikNo = value;
                        }
                        else
                        {
                            kontrolEt = true;
                            break;
                        }
                    }
                    if(kontrolEt)
                    {
                        Console.WriteLine("TC kimlik numaranızda geçersiz karakter bulundu!!!");
                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik numaranız 11 karakter olmalı!!!");  
                }
            }
        }
    }
}
