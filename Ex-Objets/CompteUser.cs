using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Objets
{
    class CompteUser
    {
        public bool CreerUser(string UserName) 
        {
            char[] code= new char[UserName.Length];
            bool isDigitSub0 = false;
            for (int a = 0; a<UserName.Length; a++)
            {
                if (char.IsDigit(UserName[a]))
                {
                    int b = (int)UserName[a];
                    if (b > 10)
                    {
                        isDigitSub0 = true;
                        b--;
                    }
                    else 
                    {
                        isDigitSub0 = false;
                        b++;
                    }
                    code[a] = ((char)b);
                }
            }
            return true;
        }
     }
}
