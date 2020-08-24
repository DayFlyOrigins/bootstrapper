
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B00TSTRAPP3R
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "𝒟𝒽𝒶𝓃𝓉𝑀𝑜𝒹𝒹𝑒𝓇 (𝐵𝒪𝒪𝒯𝒮𝒯𝑅𝒜𝒫𝒫𝐸𝑅)"; // do i need to explain this?
            Console.ForegroundColor = ConsoleColor.Red; // uses the color red. the color can be costumize

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("DHANTMODDER | BOOTSTRAPPERV2");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");






            Console.WriteLine("Checking Versions.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfully checked! Up-To-Date.");
            Console.ForegroundColor = ConsoleColor.Yellow; // Change the color to any that you wan't!
            Console.WriteLine("[+] Downloading..."); // Writes an information, that it's downloading files.
            WebClient wc = new WebClient(); // Creates a new name for WebClient.
            String program = "name"; // rename "name" to the file you will download!
            String link = "link here"; // Link to download. It has to be a pastebin and in RAW!
            String download = wc.DownloadString(link); // Reads the file which will be Downloaded.
            String path = @"Downloaded\" + program; // This script extracts the file from the rar to the Downloaded folder.
            String patch = (@"Downloaded"); // The folder name where the downloaded file should be putted in.
            Console.WriteLine("[+] Creating Folder..."); // Informs the user, that the folder is creating.
            Directory.CreateDirectory(patch); // Creates the folder.
            Console.WriteLine("[+] Extracting files..."); // Informs the user, that the file is being extracted.
            wc.DownloadFile(download, path); // Downloads the file and the Folder.
            Console.ForegroundColor = ConsoleColor.Green; // Customize the color to any you would wan't!
            Console.WriteLine("[+] Succesfully Downloaded."); // Succesfully informs that the file was downloaded!
            Console.ForegroundColor = ConsoleColor.Blue; // Over again, fully customizable! 
            Console.WriteLine("Press Any Key To Continue..."); // Messages the user that they can click any key to close this.
            Console.ReadKey(); // When a key is detected, the boostrapper closes!
        }
    }
}
