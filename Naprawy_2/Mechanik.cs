using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naprawy_2
{
    class Mechanik
    {
        internal string imię_nazwisko;
        internal int rok_rozpoczęcia_pracy;
        internal decimal stawka;
        internal decimal wynagrodzenie;

        public override string ToString()
        {
            return imię_nazwisko;
        }

        internal static List<Mechanik> lista_mechaników = new List<Mechanik>();
        internal static void dodaj_mechanika()
        {
            //Nowak
            #region

            Mechanik pierwszy_mechanik = new Mechanik();
            pierwszy_mechanik.imię_nazwisko = "Piotr Nowak";
            pierwszy_mechanik.rok_rozpoczęcia_pracy = 2013;
            pierwszy_mechanik.stawka = 70m;
            pierwszy_mechanik.wynagrodzenie = 0m;

            lista_mechaników.Add(pierwszy_mechanik);

            #endregion

            //Romanowicz
            #region 

            Mechanik drugi_mechanik = new Mechanik();
            drugi_mechanik.imię_nazwisko = "Łukasz Romanowicz";
            drugi_mechanik.rok_rozpoczęcia_pracy = 2015;
            drugi_mechanik.stawka = 62.50m;
            drugi_mechanik.wynagrodzenie = 0m;

            lista_mechaników.Add(drugi_mechanik);

            #endregion

            //Urbański
            #region

            Mechanik trzeci_mechanik = new Mechanik();
            trzeci_mechanik.imię_nazwisko = "Sebastian Urbański";
            trzeci_mechanik.rok_rozpoczęcia_pracy = 2019;
            trzeci_mechanik.stawka = 55.50m;
            trzeci_mechanik.wynagrodzenie = 0m;

            lista_mechaników.Add(trzeci_mechanik);

            #endregion

            //Wasilewski
            #region 

            Mechanik czwarty_mechanik = new Mechanik();
            czwarty_mechanik.imię_nazwisko = "Marcin Wasilewski";
            czwarty_mechanik.rok_rozpoczęcia_pracy = 2020;
            czwarty_mechanik.stawka = 50m;
            czwarty_mechanik.wynagrodzenie = 0m;

            lista_mechaników.Add(czwarty_mechanik);

            #endregion
        }
    }
}
