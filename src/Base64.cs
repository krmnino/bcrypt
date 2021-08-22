using System;
using System.Collections.Generic;
using System.Text;

namespace Bcrypt
{
    class Base64
    {
        private readonly Char[] base64 = {
            '.', '/', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b',
            'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
            'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5',
            '6', '7', '8', '9' };

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

        public String Encoder(ref Byte[] input_data)
        {
            List<Char> buffer = new List<Char>();
            int p = 0;
            UInt32 c1;
            UInt32 c2;
            String ret;
            while (p < input_data.Length)
            {
                c1 = (UInt32)(input_data[p++] & 0xff);
                buffer.Add(this.base64[(c1 >> 2) & 0x3f]);
                c1 = (c1 & 0x03) << 4;
                if (p >= input_data.Length)
                {
                    buffer.Add(this.base64[c1 & 0x3f]);
                    break;
                }
                c2 = (UInt32)(input_data[p++] & 0xff);
                c1 |= (c2 >> 4) & 0x0f;
                buffer.Add(this.base64[c1 & 0x3f]);
                c1 = (c2 & 0x0f) << 2;
                if (p >= input_data.Length)
                {
                    buffer.Add(this.base64[c1 & 0x3f]);
                    break;
                }
                c2 = (UInt32)(input_data[p++] & 0xff);
                c1 |= (c2 >> 6) & 0x03;
                buffer.Add(this.base64[c1 & 0x3f]);
                buffer.Add(this.base64[c2 & 0x3f]);
            }
            ret = new String(buffer.ToArray());
            return ret;
        }

        public Byte[] Decoder(ref String input_str, int max_length)
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
