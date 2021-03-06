﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skrypt.Tokenization;
using Skrypt.Parsing;
using Skrypt.Engine;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace Skrypt {
    class Program {
        static void Main(string[] args) {

            // Get skrypt test code
            var path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"..\..\SkryptFiles\testcode.sk");
            var code = File.ReadAllText(path);

            // Creating a skrypt engine object
            SkryptEngine engine = new SkryptEngine();

            // Parsing code using the engine
            //try {
                engine.Parse(code);
            //} catch (Exception e) {
            //   Console.WriteLine(e.Message);
            //}

            Stopwatch stopwatch = Stopwatch.StartNew();

            int b = 0;
            string a = "";

            while (b < 100000) {
                b++;
                a = a + "kek";
            }

            stopwatch.Stop();
            double T_Execute = stopwatch.ElapsedMilliseconds;

            Console.WriteLine("Test: {0}ms", T_Execute);

            Console.ReadKey();
        }
    }


}
