using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Task5_14;

public partial class MainWindow : Window
{
    private List<IPrintingDevice> _devices;
    public MainWindow()
    {
        InitializeComponent();
        _devices = new List<IPrintingDevice>();
    }

    private void CreateDeviceBtn_clicked(object? sender, RoutedEventArgs args)
    {
        LazerPrinter printer = new LazerPrinter(PrinterNameBox.Text, Int32.Parse(PaperCountBox.Text));
        printer.DeviceId = Int32.Parse(IdBox.Text);
        printer.SendDocumentToPrinter(DocumentBox.Text);
        _devices.Add(printer);
        TextBlock printerBlock = new TextBlock();
        printerBlock.Text = $"Устройство № {printer.DeviceId}";
        DevicesList.Children.Add(printerBlock);
    }
    
    private void PrintBtn_onClicked(object? sender, RoutedEventArgs args)
    {
        string result = "Устройства с таким номером не найдено";
        int id = Int32.Parse(PrintDeviceIdBox.Text);
        foreach (var device in _devices)
        {
            if (device.DeviceId == id)
            {
                result = device.Print();
                break;
            }
        }

        var msgBox = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow("Результат печати", result);
        msgBox.Show();
    }
}