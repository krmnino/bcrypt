using System;
using System.Collections.Generic;
using System.Text;

namespace Bcrypt
{
    class Base64
    {
        private readonly Byte[] index64 = {
            255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
            255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
            255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
            255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
            255, 255, 255, 255, 255, 255, 0, 1, 54, 55,
            56, 57, 58, 59, 60, 61, 62, 63, 255, 255,
            255, 255, 255, 255, 255, 2, 3, 4, 5, 6,
            7, 8, 9, 10, 11, 12, 13, 14, 15, 16,
            17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
            255, 255, 255, 255, 255, 255, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
            51, 52, 53, 255, 255, 255, 255, 255
        };

        public Base64() { }

        private Byte get_index64(UInt32 c)
        {
            return (c < 0 || c >= index64.Length) ? (Byte)255 : this.index64[c];
        }

        public String Encoder(String input_str)
        {
            return input_str;
        }

        public Byte[] Decoder(String input_str, int max_length)
        {
            List<Byte> buffer = new List<Byte>();
            int p = 0;
            int bp = 0;
            Byte c1;
            Byte c2;
            Byte c3;
            Byte c4;
            Byte[] ret;
            while ((p < input_str.Length) && (buffer.Count < max_length))
            {
                c1 = get_index64(input_str[p++]);
                c2 = get_index64(input_str[p++]);

                if (c1 == 255 || c2 == 255)
                {
                    break;
                }

                buffer.Add((Byte)((c1 << 2) | ((c2 & 0x30) >> 4)));
                bp++;

                if (buffer.Count >= max_length || p >= input_str.Length)
                {
                    break;
                }

                c3 = get_index64(input_str[p++]);

                if (c3 == 255)
                {
                    break;
                }

                buffer.Add((Byte)(((c2 & 0x0f) << 4) | ((c3 & 0x3c) >> 2)));

                if (buffer.Count >= max_length || p >= input_str.Length)
                {
                    break;
                }

                c4 = get_index64(input_str[p++]);

                buffer.Add((Byte)(((c3 & 0x03) << 6) | c4));
            }
            ret = new Byte[buffer.Count];
            for(int i = 0; i < ret.Length; i++)
            {
                ret[i] = buffer[i];
            }
            return ret;
        }
    }
}
