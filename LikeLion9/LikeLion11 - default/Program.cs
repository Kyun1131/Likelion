﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion11___default
{
    class Program
    {
        static void Main(string[] args)
        {
            // default 키워드를 이영한 기본값 설정
            int defaultInt = default; // 기본값 : 0
            string defaultString = default; // 기본값 : null
            bool defaultBool = default; // 기본값 : false

            Console.WriteLine($"정수 기본값 : {defaultInt}");
            Console.WriteLine($"문자열 기본값 : {defaultString}");
            Console.WriteLine($"논리값 기본값 : {defaultBool}");

        }
    }
}
