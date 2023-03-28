namespace Task5_14;

public interface IPrintingDevice
{
    string DriverType { get; set; }

    string Print();
    int GetPrintingStatus();
}