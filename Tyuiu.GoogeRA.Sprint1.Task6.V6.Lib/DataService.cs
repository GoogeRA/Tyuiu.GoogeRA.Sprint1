﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoogeRA.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {

            String[] words = value.Split(' ');
            string answer = "";
            for (int i = 0; i < words.Length; i++)
            {
               answer += words[i].Substring(1) + " ";
            }
            return answer;
        }
    }
}