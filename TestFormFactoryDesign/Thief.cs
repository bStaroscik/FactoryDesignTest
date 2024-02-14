using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormFactoryDesign
{
    public class Thief : INPC 
    {
        public string Create ()
        {
            string npcResponse;
            npcResponse = "Fighter Created";
            return npcResponse;
        }
    }
}
