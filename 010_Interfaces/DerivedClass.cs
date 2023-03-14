﻿using System;

namespace Interfaces
{
    public class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2");
        }
    }
}
