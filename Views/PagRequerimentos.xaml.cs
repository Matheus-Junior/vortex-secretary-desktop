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
public partial class PagRequerimentos : Window
{
    public PagRequerimentos()
    {
        InitializeComponent();
        this.WindowState = WindowState.Maximized;

        for (int i = 0; i < 10; i++)
        {
            var requerimentoNovo = new RequerimentoNovo();
            requerimentoNovo.PreviewMouseLeftButtonDown += OpenNoteExtended;
            requerimentosNovosWrapPanel.Children.Add(requerimentoNovo);
        }
        
        for (int i = 0; i < 10; i++)
        {
            var requerimentoEmAndamento = new RequerimentoEmAndamento();
            requerimentoEmAndamento.PreviewMouseLeftButtonDown += OpenNoteExtended;
            requerimentosEmAndamentoWrapPanel.Children.Add(requerimentoEmAndamento);
        }
        
    }
    private void OpenNoteExtended(object sender, MouseButtonEventArgs e)
    {
        
            /*var requerimento*/
            var requerimentoExtendido = new Template();

            requerimentoExtendidoContainer.Content = requerimentoExtendido;
            requerimentoExtendidoContainer.Visibility = Visibility.Visible;
            mainGrid.Opacity = 0.3;
            /*noteCard.Visibility = Visibility.Collapsed;*/
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
}
