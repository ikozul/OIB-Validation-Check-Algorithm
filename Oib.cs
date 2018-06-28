
    public class Oib
    {
        internal bool CheckOIB(string oib)
        {
            if (oib.Length != 11) return false;

            long b;
            if (!long.TryParse(oib, out b)) return false;

            int a = 10;
            for (int i = 0; i < 10; i++)
            {
                a = a + Convert.ToInt32(oib.Substring(i, 1));
                a = a % 10;
                if (a == 0) a = 10;
                a *= 2;
                a = a % 11;
            }
            int control = 11 - a;
            if (control == 10) control = 0;

            return control == Convert.ToInt32(oib.Substring(10, 1));
        }


    }
