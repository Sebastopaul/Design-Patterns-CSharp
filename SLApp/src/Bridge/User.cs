using System;

namespace SLApp.Bridge;

public class User
{
  static void Run(string[] args)
  {
    var form1 = new FormRegistrationLuxembourg(new FormImplHtml());
    form1.Display();
    if (form1.ManageInput())
      form1.GenerateDocument();
    Console.WriteLine();
    var form2 = new FormRegistrationFrance(new FormImplApplet());
    form2.Display();
    if (form2.ManageInput())
      form2.GenerateDocument();
  }
}