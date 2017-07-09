using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBot {
    class Randomizer {
        private static Random random = new Random();
        public static string RandomNumber(int Size) {
            string input = "0123456789";
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++) {
                ch = input[random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public static string RandomEmail(int Size) {
            string[] emailDomains = { "@bestvpn.top", "@10vpn.info", "@mailgov.info", "@pcmylife.com", "@garage46.com", "@uscaves.com" };
            string randomDomain = emailDomains[random.Next(emailDomains.Length)];
            return RandomName() + RandomNumber(4) + randomDomain;
        }

        public static string RandomName() {
            string path = @"C:\twitterbot\names.txt";
            var lines = File.ReadAllLines(path);
            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            string word = lines[randomLineNumber];
            return word;
        }
    }
}
