using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<K, V>
    {
        K[] key;
        V[] value;
        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }
        public void Add(K keys, V values)
        {
            K[] tempK = key;
            V[] tempV = value;

            key = new K[key.Length + 1];
            value = new V[value.Length + 1];

            for (int i = 0; i < tempK.Length; i++)
            {
                key[i] = tempK[i];
            }
            key[key.Length - 1] = keys;

            for (int i = 0; i < tempV.Length; i++)
            {
                value[i] = tempV[i];
            }
            
            value[value.Length - 1] = values;
        }
        
        public void List()
        {
            for (int i= 0; i<key.Length;i++)
            {
                Console.WriteLine("No: " + key[i]+" " + "İsim: "+ value[i]);
            }
        }
    }
}
