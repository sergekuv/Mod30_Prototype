namespace Mod30_Prototype.Entities;

internal class ColorPrinter : Printer
{
    public ColorPrinter(string model, string serialNumber, int colorCount = 0) : base(model, serialNumber)
    {
        ColorCount = colorCount;
    }

    public int ColorCount { get; set; }

    public override string ToString()
    {
        return ($"SN: {SerialNumber}, model: {Model}, BwCount: {BwCount}, ColorCount: {ColorCount}");
    }

    public override ColorPrinter CloneMemberWise()
    {
        ColorPrinter result = base.CloneMemberWise() as ColorPrinter;
        result.ColorCount = this.ColorCount; 
        return result;
    }

    public override ColorPrinter CloneCtor()
    {
        return new ColorPrinter(model:this.Model, serialNumber:this.SerialNumber, colorCount:this.ColorCount);
    }
}
