using System;

namespace ISPDemoConsole.Client
{
    class CannonMG2470 : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Cannon: PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Cannon: Print Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Cannon: Scan Done"); return true;
        }
     }
}