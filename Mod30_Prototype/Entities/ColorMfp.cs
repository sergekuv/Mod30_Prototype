namespace Mod30_Prototype.Entities;

internal class ColorMfp : ColorPrinter
{
    public ColorMfp(string model, string serialNumber, FaxModule faxUnit, int scanCount = 0) : base(model, serialNumber)
    {
        FaxUnit = faxUnit;
        ScanCount = scanCount;
    }

    public int ScanCount { get; set; }
    public FaxModule FaxUnit { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", ScanCount: {ScanCount}, Fax SN: {FaxUnit?.SerialNumber}, BaudRate: {FaxUnit?.BaudRate}";
    }

    public override ColorMfp CloneMemberWise()
    {
        return this.MemberwiseClone() as ColorMfp;
    }

    public ColorMfp CloneWithNewFax()
    {
        var newColorMfp = this.MemberwiseClone() as ColorMfp;
        newColorMfp.FaxUnit = this.FaxUnit.Clone();
        return newColorMfp;
    }
    public override ColorMfp CloneCtor()
    {
        return new ColorMfp(model: Model, serialNumber: SerialNumber, scanCount: ScanCount, faxUnit: FaxUnit);
    }

}
