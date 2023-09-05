namespace Mod30_Prototype.Entities;

internal class Printer : IMyCloneable<Printer>, ICloneable
{
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public int BwCount { get; set; }
    public Printer(string model, string serialNumber, int bwCount = 0)
    {
        Model = model;
        SerialNumber = serialNumber;
        BwCount = bwCount;
    }

    public virtual Printer CloneMemberWise()
    {
        return this.MemberwiseClone() as Printer;
    }
    public virtual Printer CloneCtor()
    {
        return new Printer(model: Model, serialNumber: SerialNumber, bwCount: BwCount);
    }

    public object Clone() => CloneCtor();
}
