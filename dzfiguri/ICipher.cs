using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzfiguri
{
    public class ACipher : ICipher
    {
        public string Encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (char.IsLower(chars[i]))
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'а' + 1) % 32 + (int)'а');
                    }
                    else
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'А' + 1) % 32 + (int)'А');
                    }
                }
            }
            return new string(chars);
        }

        public string Decode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (char.IsLower(chars[i]))
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'а' - 1 + 32) % 32 + (int)'а');
                    }
                    else
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'А' - 1 + 32) % 32 + (int)'А');
                    }
                }
            }
            return new string(chars);
        }
    }

    public class BCipher : ICipher
    {
        public string Encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (char.IsLower(chars[i]))
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'а' + 32 - i) % 32 + (int)'а');
                    }
                    else
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'А' + 32 - i) % 32 + (int)'А');
                    }
                }
            }
            return new string(chars);
        }

        public string Decode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (char.IsLower(chars[i]))
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'а' - 32 + i) % 32 + (int)'а');
                    }
                    else
                    {
                        chars[i] = (char)(((int)chars[i] - (int)'А' - 32 + i) % 32 + (int)'А');
                    }
                }
            }
            return new string(chars);
        }
    }