using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace LR6_XmlReader {

    class Program {
   
        static void Main(string[] args) {

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            using (XmlTextReader reader = new XmlTextReader("feed.xml")) {
                keyValuePairs.Add("no-role", 0);
                while (reader.Read()) {
                    if (reader.NodeType == XmlNodeType.Element) {
                        if (reader.Name == "user") {
                            if (reader.HasAttributes) {
                                string key = reader.GetAttribute("role");
                                if (!keyValuePairs.ContainsKey(key)) {
                                    keyValuePairs.Add(key, 1);
                                }
                                else {
                                    int value = keyValuePairs[key];
                                    keyValuePairs[key] = ++keyValuePairs[key];
                                }

                            }
                            else {
                                keyValuePairs["no-role"] = ++keyValuePairs["no-role"];
                            }
                        }


                    }
                }
            }
            foreach (KeyValuePair<string, int> entry in keyValuePairs) {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            Console.ReadLine();
        }
    }
}
