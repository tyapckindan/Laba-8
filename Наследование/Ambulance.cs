
public class Ambulance : RescueTransport
{
    public Ambulance(string name, string model, string number) : base(name, model, number) { }
    public override void GetInfo()
    {
        base.GetInfo();
    }
}

