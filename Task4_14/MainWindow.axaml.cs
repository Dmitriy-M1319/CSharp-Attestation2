using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Task4_14;

public partial class MainWindow : Window
{
    private List<ArmyParent> _parents;
    private List<ArmyChild> _childs;
    
    private TextBox _parentKind;
    private TextBox _parentCount;
    private TextBox _parentArmament;
    private TextBlock _parentListName;
    private StackPanel _parentsList;
    
    private TextBox _childKind;
    private TextBox _childCount;
    private TextBox _childArmament;
    private TextBox _childExperience;
    private TextBlock _childListName;
    private StackPanel _childList;
    public MainWindow()
    {
        InitializeComponent();
        _parents = new List<ArmyParent>();
        _childs = new List<ArmyChild>();
        
        _parentKind = this.Find<TextBox>("armyParentKind");
        _parentCount = this.Find<TextBox>("armyParentCount");
        _parentArmament = this.Find<TextBox>("armyParentArmament");
        _parentListName = this.Find<TextBlock>("parentListLabel");
        _parentsList= this.Find<StackPanel>("armyParentList");
        
        _childKind = this.Find<TextBox>("armyChildKind");
        _childCount = this.Find<TextBox>("armyChildCount");
        _childArmament = this.Find<TextBox>("armyChildArmament");
        _childExperience = this.Find<TextBox>("armyChildExperience");
        _childListName = this.Find<TextBlock>("childListLabel");
        _childList = this.Find<StackPanel>("childList");
    }


    private void CreateArmyParentBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        if (_parentKind.Text.Length == 0 || 
            _parentCount.Text.Length == 0 || 
            _parentArmament.Text.Length == 0)
        {
            var errorBox = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("Ошибка", "Неверные значения. Повторите ввод");
            errorBox.Show();
        }

        ArmyParent parent = new ArmyParent(_parentKind.Text,
            int.Parse(_parentCount.Text),
            int.Parse(_parentArmament.Text));
        _parents.Add(parent);
        if (_parentListName.Text == "")
        {
            _parentListName.Text = "Созданные объекты армий-родителей";
        }

        TextBlock block = new TextBlock();
        block.Text = parent.ToString();
        _parentsList.Children.Add(block);
    }

    private void CreateArmyChildBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        if (_childKind.Text.Length == 0 || 
            _childCount.Text.Length == 0 || 
            _childArmament.Text.Length == 0 || 
            _childExperience.Text.Length == 0)
        {
            var errorBox = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("Ошибка", "Неверные значения. Повторите ввод");
            errorBox.Show();
        }

        ArmyChild child = new ArmyChild(_childKind.Text,
            int.Parse(_childCount.Text),
            int.Parse(_childArmament.Text),
            int.Parse(_childExperience.Text));
        _childs.Add(child);
        if (_childListName.Text == "")
        {
            _childListName.Text = "Созданные объекты армий-потомков";
        }

        TextBlock block = new TextBlock();
        block.Text = child.ToString();
        _childList.Children.Add(block);
    }
}