﻿namespace Deneme_RealProxy
{
    public class Operations : IOps
    {
        public string Name { get; set; } = "husnu";
        public virtual int Age { get; set; } = 1111;

        public virtual int Add(int a, int b)
        {
            return a + b;
        }

        public virtual int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
