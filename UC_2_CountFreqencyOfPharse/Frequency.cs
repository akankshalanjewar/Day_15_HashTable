﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_2_CountFreqencyOfPharse
{
    class Frequency
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        public void Freqncy(MyMapNode<int, string> hash)
        {
            for (int key = 0; key < hash.size; key++)
            {
                frequency.TryAdd(hash.Get(key).ToLower(), 0);
                frequency[hash.Get(key).ToLower()]++;
            }
            foreach (KeyValuePair<string, int> item in frequency)
            {
                Console.WriteLine("Frequency of word " + item.Key + " is : " + item.Value);
                Console.WriteLine("-----------------------------------------------");
            }
        }
    }
}




