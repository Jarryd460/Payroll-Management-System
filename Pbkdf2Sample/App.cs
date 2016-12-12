using System;
using System.Security.Cryptography;
using Medo.Security.Cryptography;

namespace Pbkdf2Sample {
    class App {
        static void Main(string[] args) {
            var password = "password";
            var salt = "salt";
            var iterations = 4096;
            using (var hmac = new HMACSHA256()) {
                var df = new Pbkdf2(hmac, password, salt, iterations);
                Console.WriteLine(BitConverter.ToString(df.GetBytes(32)));
            }

            Console.ReadKey();
        }
    }
}
