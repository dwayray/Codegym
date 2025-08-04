﻿using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });

                // Truy cập sai chỉ số
                char value = characters[6]; // Index 6 không tồn tại (chỉ có 0-5)
                Console.WriteLine(value);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Caught an ArgumentOutOfRangeException:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
