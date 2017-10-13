
using StorageGUI.Extentions;
using StorageGUI.IGameCentralServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace StorageGUI
{
    /// <summary>
    /// Interaction logic for CreateProductWin.xaml
    /// </summary>
    public partial class CreateProductWin : Window
    {

        IGameCentralServiceReference1.IGameCentralServiceProduct client = new IGameCentralServiceReference1.GameCentralServiceProductClient();
        public CreateProductWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.Create(0, NameTextField.Text, Convert.ToDouble (PriceTextField.Text), DescriptionTextField.Text, Convert.ToInt32 (StockTextField.Text), 0);
            client.Create(p);
            MessageBox.Show("Du har tilføjet " + p.Name);
            Close();
        }


    }
}
