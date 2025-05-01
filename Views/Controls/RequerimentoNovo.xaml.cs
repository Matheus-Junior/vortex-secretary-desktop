using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vortex_secretary_desktop.Views.Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class RequerimentoNovo : UserControl
{
    public RequerimentoNovo()
    {
        InitializeComponent();
    }

    public void btnEntrar_Click(object sender, MouseButtonEventArgs e)
    {
        PagInicio home = new PagInicio();
        home.Show();
    }

}