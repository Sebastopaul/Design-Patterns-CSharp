namespace SLApp.AnotherUnknownPattern;

public abstract class FormRegistration
{
  private string? _content = null;
  private readonly IFormImpl _implantation;

  protected FormRegistration(IFormImpl implantation)
  {
    this._implantation = implantation;
  }

  public void Display()
  {
    _implantation.DrawText("Existing plate number : ");
  }

  public void GenerateDocument()
  {
    _implantation.DrawText("Registration request");
    _implantation.DrawText("Plate number : " + _content);
  }

  public bool ManageInput()
  {
    _content = _implantation.ManageInputArea();
    return this.ControlInput(_content);
  }

  protected abstract bool ControlInput(string plate);
}