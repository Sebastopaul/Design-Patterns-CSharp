namespace SLApp.Decorator;

public class FormRegistrationFrance :
  FormRegistration
{
  public FormRegistrationFrance(IFormImpl implantation) : base(implantation){}

  protected override bool ControlInput(string plate)
  {
    return plate.Length == 7;
  }
}