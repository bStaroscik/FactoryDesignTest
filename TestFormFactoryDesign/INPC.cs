using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormFactoryDesign
{
    public interface INPC
    {
        int Strength();
        int Dexterity();
        int Constitution();
        int Intelligence();
        int Wisdom();
        int Charisma();

        string Create();
    }
}
