using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HexDecimal
{
    public class Hexdecimal
    {
        private int Ivalue;
        public int IntValue { get { return Ivalue; } set { Ivalue = value; } }
        private string Svalue;
        public string StringValue { get { return Svalue; } set { try { ConvertToInt(value); Svalue = value; } catch { } } }
        public Hexdecimal(string _value)
        {
            Svalue = _value;
            Ivalue = Hexdecimal.ConvertToInt(_value);
        }
        public Hexdecimal(int _value)
        {
            Ivalue = _value;
            Svalue = Hexdecimal.ConvertToHex(_value);
        }
        public static string ConvertToHex(int _value)
        {
            char[] i = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            string s = "";
            int r = 1;
            int Q = 1;
            while (Q != 0)
            {
                Q = _value / 16;
                r = _value - Q * 16;
                if (Q != 0)
                {
                    s += i[Q];
                }
                else { s += i[r]; }
                _value = r;
            }
            return s;
        }
        public static int ConvertToInt(string Hex)
        {
            char[] i = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (!IsHexdecimal(Hex))
            {
                throw new System.ArgumentException("Please enter a valid hex value");
            }
            int len = Hex.Length - 1;
            int r = 0;
            foreach (char c in Hex)
            {
                r += Array.IndexOf(i, c) * pow(16, len);
                len--;
            }
            return r;
        }
        private static int pow(int x, int y)
        {
            int r = 1;
            for (int i = 0; i < y; i++)
            {
                r *= x;
            }
            return r;
        }
        public static bool IsHexdecimal(string h)
        {
            char[] i = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char c in h)
            {
                if (!i.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
