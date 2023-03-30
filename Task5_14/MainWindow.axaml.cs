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
    }

    public void LoadPrinters()
    {
    }

    private void CreateDeviceBtn_clicked(object? sender, RoutedEventArgs args)
    {
        LazerPrinter printer = new LazerPrinter(PrinterNameBox.Text, Int32.Parse(PaperCountBox.Text));
        printer.DeviceId = Int32.Parse(IdBox.Text);
        printer.SendDocumentToPrinter(DocumentBox.Text);
        _devices
    }
}