using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Engine
{
    public class RandomNumberGenerator
    {
        private static readonly Random _generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _generator.Next(minimumValue, maximumValue + 1);
        }
    }
}
