using System;
using System.Collections.Generic;
// Language integrated query. Makes it easy to query from .net
using System.Linq;
using System.Xml.Linq;

namespace folders
{
    public class Folders
    {
        // IEnumerable<string>
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            XDocument xmlFile = XDocument.Parse(xml);
            var folders = xmlFile.Descendants("folder").ToList();
            var result = folders.Where(p => p.FirstAttribute.Value.StartsWith(startingLetter.ToString())).Select(p => p.FirstAttribute.Value).ToList();
            return result;
        }

        // public static void Main(string[] args)
        // {
        //     string xml =
        //         "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
        //         "<folder name=\"c\">" +
        //             "<folder name=\"program files\">" +
        //                 "<folder name=\"uninstall information\" />" +
        //             "</folder>" +
        //             "<folder name=\"users\" />" +
        //         "</folder>";

        //     foreach (string name in Folders.FolderNames(xml, 'u')) {
        //         Console.WriteLine(name);
        //     }
        // }
    }
}