using Colors.Net;
using static Colors.Net.StringStaticMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamApidotnet
{
    public class Logger
    {
        public static void Info(string name, string message)
        {
            ColoredConsole.WriteLine($"{Cyan(string.Format("{0:hh:mm:ss tt}", DateTime.Now).ToUpper())}{Gray(" - ")}{Blue("[")}{Cyan(name)}{Blue("]")} {Green("Info")}{Gray(" | ")}{Green(message)}");
        }
        public static void Warn(string name, string message)
        {
            ColoredConsole.WriteLine($"{Cyan(string.Format("{0:hh:mm:ss tt}", DateTime.Now).ToUpper())}{Gray(" - ")}{Blue("[")}{Cyan(name)}{Blue("]")} {Yellow("Warn")}{Gray(" | ")}{Yellow(message)}");
        }
        public static void Error(string name, string message)
        {
            ColoredConsole.WriteLine($"{Cyan(string.Format("{0:hh:mm:ss tt}", DateTime.Now).ToUpper())}{Gray(" - ")}{Blue("[")}{Cyan(name)}{Blue("]")} {Red("Error")}{Gray(" | ")}{Red(message)}");
        }
    }
}
