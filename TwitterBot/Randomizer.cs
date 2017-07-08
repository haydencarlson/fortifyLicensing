using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBot {
    class Randomizer {
        private static Random random = new Random();
        private string RandomString(int Size) {
            string input = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++) {
                ch = input[random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        private string RandomEmail(int Size) {
            string[] emailDomains = { "@bestvpn.top", "@10vpn.info", "@mailgov.info", "@pcmylife.com", "@garage46.com", "@uscaves.com" };
            string randomDomain = emailDomains[random.Next(emailDomains.Length)];
            return RandomString(8) + randomDomain;
        }
    }
}
