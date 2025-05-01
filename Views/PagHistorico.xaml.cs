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
public partial class PagHistorico : Window
{
    private Template _historicoExtendido;
    public PagHistorico()
    {
        InitializeComponent();
        this.WindowState = WindowState.Maximized;

        for (int i = 0; i < 10; i++)
        {
            var historico = new Historico();
            historico.PreviewMouseLeftButtonDown += AbrirHistorico;
            duvidaWrapPanel.Children.Add(historico);
        }
    }
    private void AbrirHistorico(object sender, MouseButtonEventArgs e)
    {
        
            var historicoExtendido = new Template();
            historicoExtendidoContainer.Content = historicoExtendido;
            historicoExtendidoContainer.Visibility = Visibility.Visible;
            mainGrid.Opacity = 0.3;
            _historicoExtendido = historicoExtendido;
    }
    
    private void AbrirRequerimentos(object sender, MouseButtonEventArgs e)
    {
        PagInicio pagInicio = new PagInicio();
        pagInicio.Show();
        this.Close();
    }
    
    private void AbrirDuvidas(object sender, MouseButtonEventArgs e)
    {
        PagDuvidas pagDuvidas = new PagDuvidas();
        pagDuvidas.Show();
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
        if (this._historicoExtendido != null && !ClicouDentro(historicoExtendidoContainer, elementoClicado))
        {
            try
            {
                historicoExtendidoContainer.Content = null;
                historicoExtendidoContainer.Visibility = Visibility.Collapsed;
                mainGrid.Opacity = 1;
                this._historicoExtendido = null;
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