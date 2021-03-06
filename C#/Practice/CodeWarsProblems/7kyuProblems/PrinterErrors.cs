﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CodeWarsProblems._7kyuProblems
{
    //https://www.codewars.com/kata/56541980fa08ab47a0000040
    [TestClass]
    public class PrinterErrors
    {
        public static string PrinterError(String s)
        {
            int unacceptable =
            s
            .Where(IsCharInvalid)
            .Count();

            /*int unacceptable = 0;
            var length = s.Length;
            for(int i = 0; i < length; i++)
            {
              if(s[i] - 'a' >= 13)
                unacceptable++;
            } */

            return $"{unacceptable}/{s.Length}";
        }

        private static bool IsCharInvalid(char c) => c - 'a' >= 13;

        [TestMethod]
        [TestCategory("7kyu")]
        public void PrintErrorsTest()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", PrinterError(s));
        }
    }
}
