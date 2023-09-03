using Mod30_Prototype.Entities;

namespace Mod30_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FaxModule fax = new FaxModule(sn: 11, baudRate: 2400);
            ColorMfp mfp1 = new ColorMfp(model: "NoName", serialNumber: "1111", faxUnit: fax);

            Console.WriteLine("== Using IMyCloneable ==");
            Console.WriteLine("Создание клона при помощи MemberwiseClone, учитывающее наличие ассоциированного объекта (модуля факса)");
            var mfp2 = mfp1.CloneWithNewFax();
            mfp2.SerialNumber = "2222";
            mfp2.FaxUnit.SerialNumber = 22;
            Console.WriteLine("mfp1: " + mfp1.ToString());
            Console.WriteLine("mfp2: " + mfp2.ToString() + "\n");

            Console.WriteLine("Создание клона при помощи MemberwiseClone, не учитывающее наличие ассоциированного объекта (модуля факса)");
            var mfp3 = mfp1.CloneMemberWise();
            mfp3.SerialNumber = "3333";
            mfp3.FaxUnit.SerialNumber = 33;
            Console.WriteLine("mfp1: " + mfp1.ToString());
            Console.WriteLine("mfp3: " + mfp3.ToString() + "\n");

            Console.WriteLine("Создание клона при помощи конструктора, не учитывающее наличие ассоциированного объекта (модуля факса)");
            var mfp4 = mfp2.CloneCtor();
            mfp4.SerialNumber = "4444";
            mfp4.FaxUnit.SerialNumber = 44;
            Console.WriteLine("mfp2: " + mfp2.ToString());
            Console.WriteLine("mfp4: " + mfp4.ToString());

            Console.WriteLine("\n== Using Clone ==");
            Console.WriteLine("Создание клона при помощи конструктора, не учитывающее наличие ассоциированного объекта (модуля факса)");
            var mfp5 = new ColorMfp(model: "MFP5 proto", serialNumber: "5555", faxUnit: new FaxModule(sn: 55, baudRate: 4800), scanCount: 55);
            var mfp6 = mfp5.Clone() as ColorMfp;
            mfp6.SerialNumber = "6666";
            mfp6.FaxUnit.SerialNumber = 66;
            Console.WriteLine("mfp5: " + mfp5.ToString());
            Console.WriteLine("mfp6: " + mfp6.ToString());

        }
    }
}