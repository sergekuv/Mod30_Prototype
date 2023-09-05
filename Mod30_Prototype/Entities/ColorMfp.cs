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
        ColorMfp result = base.CloneMemberWise() as ColorMfp;
        result.ScanCount = this.ScanCount;
        result.FaxUnit = this.FaxUnit.Clone() as FaxModule;
        return result ;

    }

    public ColorMfp CloneWithNewFax()
    {
        var newColorMfp = this.MemberwiseClone() as ColorMfp;
        newColorMfp.FaxUnit = this.FaxUnit.Clone();
        return newColorMfp;
    }
    public override ColorMfp CloneCtor()
    {
        return new ColorMfp(model: this.Model, serialNumber: this.SerialNumber, faxUnit: this.FaxUnit.Clone(), scanCount:this.ScanCount);
    }

}
