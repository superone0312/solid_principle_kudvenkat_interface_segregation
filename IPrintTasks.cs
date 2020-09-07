namespace ISPDemoConsole
{
  interface IPrintScanContent
  {
    bool PhotoCopyContent(string content);
    bool PrintContent(string content);
    bool ScanContent(string content);      
  }
    
  interface IFaxContent
  {
    bool FaxContent(string content);
  }

  interface IPrintDuplex
  {
    bool PrintDuplexContent(string content);
  }
}