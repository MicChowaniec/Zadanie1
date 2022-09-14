using System;

namespace Zadanie1
{
    public class Ulamek : IComparable<Ulamek>, IEquatable<Ulamek>
    {

        /// <summary>
        /// zarowno licznik jak i mianownik przyjmują wartości float więc należy dodać f.
        /// </summary>
        private float licznik;

        public float Licznik
        {
            get { return licznik; }
        }
        private float mianownik;

        public float Mianownik
        {
            get { return mianownik; }
        }

        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        /// 
        public Ulamek()
        {

        }

        /// <summary>
        /// konstruktor o dwóch parametrach 
        /// </summary>
        /// <param name="licznik"></param>
        /// <param name="mianownik"></param>
        public Ulamek(float licznik, float mianownik)
        {
            if (mianownik == 0)
            {
                throw new ArgumentException("mianownik nie może być zero", nameof(mianownik));
            }
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        /// <summary>
        /// konstruktor kopiujący
        /// </summary>
        /// <param name="ulamek"></param>
        public Ulamek(Ulamek ulamek)
        {
            this.licznik = ulamek.licznik;
            this.mianownik = ulamek.mianownik;
        }


        /// <summary>
        /// wyswietlanie wyniku przy pomocy metody ulamek.ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string wyswietl = licznik + "/" + mianownik;
            return wyswietl;
        }


        /// <summary>
        /// Definicja Funkcji porównującej ułamki
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Ulamek? other)
        {
            if (other == null) return 1;
            if (this == null) return -1;
            if (other == this) return 0;
            if ((this.licznik == other.licznik) && (this.mianownik == other.mianownik)) return 0;
            if ((this.licznik * other.mianownik) > (this.mianownik * other.licznik)) return 1;
            else return -1;

        }

        /// <summary>
        /// Definicja Funkcji sprawdzającej równośc ułamków
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Ulamek? other)
        {
            if ((this.licznik == other.licznik) && (this.mianownik == other.mianownik)) return true;
            if ((this.licznik * other.mianownik) == (this.mianownik * other.licznik)) return true;
            else return false;
        }


        /// <summary>
        /// przeciazenie operatora dodawania
        /// </summary>
        /// <param name="ulamek"></param>
        /// <returns></returns>
        public static Ulamek operator +(Ulamek ulamek) => ulamek;

        /// <summary>
        /// przeciazenie operatora dodawania
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static Ulamek operator +(Ulamek u1, Ulamek u2) => new Ulamek(u1.licznik * u2.mianownik + u2.licznik * u1.mianownik, u1.mianownik * u2.mianownik);

        /// <summary>
        /// przeciazenie operatora odejmowania
        /// </summary>
        /// <param name="ulamek"></param>
        /// <returns></returns>
        public static Ulamek operator -(Ulamek ulamek) => new Ulamek(-ulamek.licznik,ulamek.mianownik);

        /// <summary>
        /// przeciazenie operatora odejmowania
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static Ulamek operator -(Ulamek u1, Ulamek u2) => new Ulamek(u1.licznik * u2.mianownik - u2.licznik * u1.mianownik, u1.mianownik * u2.mianownik);

        /// <summary>
        /// przeciazenie operatora mnozenia
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static Ulamek operator *(Ulamek u1, Ulamek u2) => new Ulamek(u1.licznik * u2.licznik, u1.mianownik * u2.mianownik);

        /// <summary>
        /// przeciazenie operatora dzielenia
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static Ulamek operator /(Ulamek u1, Ulamek u2) => new Ulamek(u1.licznik * u2.mianownik, u1.mianownik * u2.licznik);

    }

 
}