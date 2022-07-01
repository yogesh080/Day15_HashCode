using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Frequency
    {
        Hashtable MyMapNode = new Hashtable();
        

        //public string[] splitString(string sentence)
        //{
        //    return sentence.Split();
        //}

        public void countWords(string[] sentenceSplit)
        {
            foreach (string key in sentenceSplit)
            {
                if (MyMapNode.ContainsKey(key)){
                    MyMapNode[key]=(int)MyMapNode[key] +1;
                }
                else
                {
                    MyMapNode.Add(key,1);

                }
            }
            foreach (DictionaryEntry item in MyMapNode)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }   
        }
    }

}