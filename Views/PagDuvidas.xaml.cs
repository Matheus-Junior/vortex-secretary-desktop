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
public partial class PagDuvidas : Window
{
    private DuvidaExtendida _duvidaExtendida;
    public PagDuvidas()
    {
        InitializeComponent();
        this.WindowState = WindowState.Maximized;

        for (int i = 0; i < 10; i++)
        {
            var duvida = new Duvida();
            duvida.PreviewMouseLeftButtonDown += AbrirDuvida;
            duvidaWrapPanel.Children.Add(duvida);
        }
    }
    private void AbrirDuvida(object sender, MouseButtonEventArgs e)
    {
        
            var duvidaExtendida = new DuvidaExtendida();
            duvidaExtendidaContainer.Content = duvidaExtendida;
            duvidaExtendidaContainer.Visibility = Visibility.Visible;
            mainGrid.Opacity = 0.3;
            _duvidaExtendida = duvidaExtendida;
    }

    private void AbrirRequerimentos(object sender, MouseButtonEventArgs e)
    {
        PagInicio pagRequerimentos = new PagInicio();
        pagRequerimentos.Show();
        this.Close();
    }
    
    private void AbrirHistorico(object sender, MouseButtonEventArgs e)
    {
        PagHistorico pagHistorico = new PagHistorico();
        pagHistorico.Show();
        this.Close();
    }
    private void AbrirGerenciamento(object sender, MouseButtonEventArgs e)
    {
        PagGerenciamento pagGerenciamento = new PagGerenciamento();
        pagGerenciamento.Show();
        this.Close();
    }
    
    private void FecharPrograma(object sender, MouseButtonEventArgs e)
    {
        this.Close();
    }
    
    private void ClicouJanela(object sender, MouseButtonEventArgs e)
    {
        var elementoClicado = e.OriginalSource as DependencyObject;
        if (this._duvidaExtendida != null && !ClicouDentro(duvidaExtendidaContainer, elementoClicado))
        {
            try
            {
                duvidaExtendidaContainer.Content = null;
                duvidaExtendidaContainer.Visibility = Visibility.Collapsed;
                mainGrid.Opacity = 1;
                this._duvidaExtendida = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao contrair requerimento: {ex.Message}", "Erro", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
    
    private bool ClicouDentro(FrameworkElement container, DependencyObject clickedElement)
    {
        while (clickedElement != null)
        {
            if (clickedElement == container)
            {
                return true;
            }
            /* parte para o próximo elemento filho */
            clickedElement = VisualTreeHelper.GetParent(clickedElement);
        }
        return false;
    }
}