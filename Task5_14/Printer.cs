namespace Task5_14;

public abstract class Printer: IPrintingDevice
{
    public string DriverType { get; set; }
    public int PrintProcess { get; set; }
    public string Print()
    {
        return "Сообщение напечатано от класса устройств Printer";
    }

    public int GetPrintingStatus()
    {
        
    }
}