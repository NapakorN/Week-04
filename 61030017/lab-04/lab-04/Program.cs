﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    class Program
    {
        static void Main(string[] args)
    {
        for (float i = 0; i < Math.PI * 2.0F; i += 0.3F)
        {
            Console.WriteLine("The cosine of {0,10:F} = {1,-10:F6}" + spaces(Math.Cos(i)) + "*", i, Math.Cos(i));
        }
    }
    private static string spaces(double val)
    {
        string SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
        return SpaceString;
    }
    }
}

