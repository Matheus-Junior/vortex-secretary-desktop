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
using vortex_secretary_desktop.Views.Controls;

namespace vortex_secretary_desktop.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class PagGerenciamento : Window
{
    public PagGerenciamento()
    {
        InitializeComponent();
        this.WindowState = WindowState.Maximized;

        for (int i = 0; i < 25; i++)
        {
            var formularioWeb = new FormularioWeb();
            formularioWrapPanel.Children.Add(formularioWeb);
        }
    }

    private void OpenNoteExtended(object sender, MouseButtonEventArgs e)
    {

        /*var requerimento*/
        var duvidaExtendida = new Template();

        duvidaExtendidaContainer.Content = duvidaExtendida;
        duvidaExtendidaContainer.Visibility = Visibility.Visible;
        mainGrid.Opacity = 0.3;
        /*noteCard.Visibility = Visibility.Collapsed;*/
    }

    private void AbrirRequerimentos(object sender, MouseButtonEventArgs e)
    {
        PagInicio pagRequerimentos = new PagInicio();
        pagRequerimentos.Show();
        this.Close();
    }

    private void AbrirDuvidas(object sender, MouseButtonEventArgs e)
    {
        PagDuvidas pagDuvidas = new PagDuvidas();
        pagDuvidas.Show();
        this.Close();
    }

    private void AbrirHistorico(object sender, MouseButtonEventArgs e)
    {
        PagHistorico pagHistorico = new PagHistorico();
        pagHistorico.Show();
        this.Close();
    }

    private void FecharPrograma(object sender, MouseButtonEventArgs e)
    {
        this.Close();
    }

}