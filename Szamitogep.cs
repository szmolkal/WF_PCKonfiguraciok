using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_PCKonfiguraciok
{
    enum EnumOpRendszer
    {
        Windows,
        Linux,
        MacOS
    }

   class Szamitogep
    {
        string stringKonfiguracioNeve;
        string stringTulajdonosNeve;
        bool boolGamerKonfiguracio;

        double functionKonfiguracioAr(bool Gamer, int OpRendszer, Int32 Ar, int Darab)
        {
            double doubleKonfiguracioAr = Ar * Darab;
            if (Gamer)
            {
                doubleKonfiguracioAr *= 1.3;
            }

            switch (OpRendszer)
            {
                case 1:
                    return doubleKonfiguracioAr + 40000;
                case 2:
                    return doubleKonfiguracioAr + 100000;
                default:
                    return doubleKonfiguracioAr;
            }

        }
    }
}
