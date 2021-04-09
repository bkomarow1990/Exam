using System;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.IO;

namespace Exam
{
    class Program
    {
        class Dict
        {
            public void Export()
            {

                string jsonStr = JsonConvert.SerializeObject(this);
                File.WriteAllText("data.json", jsonStr);
            }
            public void Import()
            {
                string json = File.ReadAllText(Path);
                JsonConvert.DeserializeObject(json);
            }
            //public void Import()
            //{
            //    this = JsonConvert.DeserializeObject(Path);
            //}
            public string Name { get; set; }
            public string Path { get; set; }
            public Dictionary<string, List<string>> dc = new Dictionary<string, List<string>>();
            public Dict(string name,string path)
            {
                Name = name;
                Path = path;
                Import();
            }
            public void WordToFile(string word, string path)
            {
                if (dc.ContainsKey(word))
                {
                    File.WriteAllText(path,$"{word} : {String.Join(' ', dc[word])}");
                }
                
            }
            public void AddWord(string one, List<string> two) {
                dc.Add(one, two);
            }
            public void ReplaceWord(string from, string to)
            {
                if (dc.ContainsKey(from))
                {
                    List<string> tmp = new List<string>(dc[from]);
                    dc.Remove(from);
                    dc.Add(from, tmp);
                }
            }
            public void FindTranslate(string word)
            {
                if (dc.ContainsKey(word))
                {
                    Console.WriteLine($"{word} : ");
                    foreach (var item in dc[word])
                    {
                        Console.WriteLine($"{item}");
                    }
                }
            }
            public void DeleteWord(string word)
            {
                if (dc.ContainsKey(word))
                {
                    dc.Remove(word);
                }
            }
            public void AddWord(string one, string two)
            {
                if (dc.ContainsKey(one))
                {
                    dc[one].Add(two);
                }
                else
                {
                    dc.Add(one, new List<string> { two});
                }
            }
        }
        static void Main(string[] args)
        {

            Dict dict = new Dict("Russian-Ukrainian","data.json");
            dict.AddWord("Проверка", "Перевірка");
            dict.AddWord("Тест", "Тестування");
            foreach (var item in dict.dc)
            {
                Console.WriteLine(item);
            }
            dict.Export();
        }
    }
}
