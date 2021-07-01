using System.Text.RegularExpressions;

namespace PizdaBot
{
    public static class Helper
    {
        private static readonly Regex Da = new (@"^(.*(\s|[^А-Яа-яA-Za-z])+)*([ДдDd]\s*[АаAa])+(\s|[^А-Яа-яA-Za-z])*$");
        private static readonly Regex Net = new (@"^(.*(\s|[^А-Яа-яA-Za-z])+)*([NnНн]\s*[EeЕе]\s*[TtТт])+(\s|[^А-Яа-яA-Za-z])*$");
        public static bool IsDa(string input)
        {
            return Da.IsMatch(input);
        }
        
        public static bool IsNet(string input)
        {
            return Net.IsMatch(input);
        }
    }
}