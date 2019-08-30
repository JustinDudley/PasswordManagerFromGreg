using System;
using System.Collections.Generic;

namespace PasswordManagerProject {
    class Program {
        static void Main(string[] args) {

            var passwordManager = new Dictionary<string, string>();
            passwordManager.Add("maxtrain.com", "123abc");
            passwordManager.Add("amazon.com", "myamazon488");
            passwordManager.Add("microsoft.com", "windows11");
            passwordManager.Add("stackoverflow.com", "ineedhelp");
            passwordManager.Add("msdn.microsoft.com", "INeedMoreHelp!");

            var password = passwordManager["maxtrain.com"];
            Console.WriteLine($"The password for maxtrain.com is {password}");

            foreach(var keyvalpair in passwordManager) {
                Console.WriteLine($"The password for {keyvalpair.Key} is {keyvalpair.Value}");
            }

            var allTheKeys = passwordManager.Keys; 
            var allTheValues = passwordManager.Values;

            var maxtrain = "maxtrain.com";
            var exists = passwordManager.ContainsKey(maxtrain);
        }
    }
}
