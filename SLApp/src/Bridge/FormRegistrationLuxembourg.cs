namespace SLApp.Bridge;

public class FormRegistrationLuxembourg :
  FormRegistration
{
  public FormRegistrationLuxembourg(IFormImpl implantation) : base(implantation){}

  protected override bool ControlInput(string plate)
  {
    return plate.Length == 5;
  }
}