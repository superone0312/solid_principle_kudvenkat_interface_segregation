using System;

namespace ISPDemoConsole
{

  class MainClass {
    public static void Main (string[] args) {
      /// why use var?
      var client = new Client.CannonMG2470();
      client.PhotoCopyContent("test text");
      client.PrintContent("test text");
      client.ScanContent("test text");
      Console.WriteLine(client.FaxContent("test text").ToString());
      Console.WriteLine(client.PrintDuplexContent("test text").ToString());

      var client2 = new Client.HPLaserJet();
      client2.FaxContent("test text");
      client2.PhotoCopyContent("test text");
      client2.PrintContent("test text");
      client2.PrintDuplexContent("test text");
      client2.ScanContent("test text");
    }
  }

}
