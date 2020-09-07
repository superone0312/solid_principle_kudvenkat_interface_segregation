using System;

namespace ISPDemoConsole.Client
{
    class HPLaserJet : IPrintScanContent, IFaxContent, IPrintDuplex
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("HP: Fax Done"); return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("HP: PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("HP: Print Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("HP: Print Duplex Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("HP: Scan Done"); return true;
        }
    }
}