namespace Task5_14;

public interface IPrintingDevice
{
    int DeviceId { get; set; }

    string Print();
    int GetPrintingStatus();
}