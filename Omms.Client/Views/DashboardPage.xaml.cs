using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;


namespace Omms.Client.Views;

public sealed partial class DashboardPage : Page
{
    public DashboardPage()
    {
        this.InitializeComponent();
    }

    private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        var rightGrid = RightGrid;

        if (e.NewSize.Width < 850)
        {
            rightGrid.Padding = new Thickness(0, 0, 0, 0);
            if (rightGrid.Parent is Grid)
            {
                grid.Children.Remove(rightGrid);
                stackPanel.Children.Add(rightGrid);
            }
        }
        else
        {
            rightGrid.Padding = new Thickness(40, 0, 0, 0); 
            if (rightGrid.Parent is StackPanel)
            {
                stackPanel.Children.Remove(rightGrid);
                grid.Children.Add(rightGrid);
            }
        }
    }
}
