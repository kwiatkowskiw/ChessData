using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LoginApplication
{
    class Hashcode
    {
        public string PassHash(string data)
        {
            SHA256 sha = SHA256.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for(int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());

            }
            return returnValue.ToString();
        }
    }
}
