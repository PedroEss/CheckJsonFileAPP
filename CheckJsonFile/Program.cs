using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CheckJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pos = new List<string>()
            {
                "9113054238",
                "9112800528",
                "9112676761",
                "9113025674",
                "9113011395",
                "9112939170",
                "9113025666",
                "9112913972",
                "9112913971",
                "9112913973",
                "9112939181",
                "9112939178",
                "9112939177",
                "9113094601",
                "9112800548",
                "9112800551",
                "9113055078",
                "9112939171"
            };
            

            var contents = Directory.GetFiles(@"C:\Users\PiotrSkiba\Desktop\L3\Brain\INCE\INC3499874\la_fusion_cost").Select(f => new
            {
                Path = f,
                Contents = File.ReadAllText(f)
            }).Where(c => pos.Any(po => c.Contents.Contains(po))).ToList();
            //contetnts.select.pa\(f => f.ForEach(Console.WriteLine));
            contents.Select(f => f.Path).ToList().ForEach(Console.WriteLine);
           
        }
    }
}
