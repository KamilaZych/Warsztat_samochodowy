using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naprawy_2
{
    class Naprawa
    {
        internal string numer_rejestracyjny;
        internal DateTime data_przyjęcia;
        internal int numer_telefonu;
        internal Mechanik mechanik;
        internal decimal koszt_użytych_części;
        internal int czas_pracy;
        internal decimal wynagrodzenie_dla_mechanika_za_naprawę;
        internal decimal cena_naprawa;
        internal static List<Naprawa> lista_napraw = new List<Naprawa>();

        internal object[] Values => new object[] { numer_rejestracyjny, data_przyjęcia, numer_telefonu, mechanik, koszt_użytych_części, 
                                                   czas_pracy, wynagrodzenie_dla_mechanika_za_naprawę, cena_naprawa };

    }
}
