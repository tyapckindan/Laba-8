public class SpecialTransport
{
    string name, model, number;
    public SpecialTransport()
    {
        name = "";
        model = "";
        number = "";
    }
    public SpecialTransport(string name, string model, string number)
    {
        this.name = name;
        this.model = model;
        this.number = number;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine(name + " Модель: " + model + " Номер: " + number + ".");
    }
}