using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task5_14;

public class DevicesViewModel: INotifyPropertyChanged
{
    private List<IPrintingDevice> _devices;

    public DevicesViewModel()
    {
        _devices = new List<IPrintingDevice>();
    }
    
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}