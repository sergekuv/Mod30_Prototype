namespace Mod30_Prototype.Entities;

internal class FaxModule
{
    public int SerialNumber { get; set; }
    public int BaudRate { get; set; }
    public FaxModule(int sn, int baudRate)
    {
        SerialNumber = sn;
        BaudRate = baudRate;
    }

    public FaxModule Clone()
    {
        return new FaxModule(SerialNumber, BaudRate);
    }
}
