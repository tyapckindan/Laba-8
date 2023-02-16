public class Program
{
    private static void Main(string[] args)
    {
        TowTruck gaz = new("Эвакуатор", "Газ-44", "А-770");
        gaz.GetInfo();
        Ambulance yaz = new("Cкорая помощь", "Уаз-452", "ИП-320");
        yaz.GetInfo();
        LargeCrane yama = new("Автокран", "КАМАЗ", "КС 45717К-1");
        yama.GetInfo();
    }
}