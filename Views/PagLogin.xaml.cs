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

namespace vortex_secretary_desktop.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class PagLogin : Window
{
    public PagLogin()
    {
        InitializeComponent();
        this.WindowState = WindowState.Maximized;
    }

    public void btnEntrar_Click(object sender, MouseButtonEventArgs e)
    {
        PagInicio pagRequerimentos = new PagInicio();
        pagRequerimentos.Show();
        this.Close();
    }

}