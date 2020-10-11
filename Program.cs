using System;
using System.IO;

namespace Rust_Save_Lag_Reducer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Rust Save Lag Reducer by Orange [1.0.0]";
            var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.cs", SearchOption.AllDirectories);
            Console.WriteLine($"{files.Length} plugins located");
            var replacedAmount = 0;
            foreach (var file in files)
            {
                var text = File.ReadAllText(file);
                var newText = text.Replace("OnServerSave", "OnCustomSave");
                if (text != newText)
                {
                    File.WriteAllText(file, newText);
                    replacedAmount++;
                }
            }
            
            Console.WriteLine($"{replacedAmount} files was modified");
            Console.WriteLine("Press any ket to exit...");
            Console.ReadKey();
        }
    }
}