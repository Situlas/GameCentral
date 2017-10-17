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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StorageGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IGameCentralServiceReference1.IGameCentralServiceProduct client = new IGameCentralServiceReference1.GameCentralServiceProductClient();

        public MainWindow()
        {
            InitializeComponent();
            ProductTableGenerator();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Find id til produktet fra den markerede på listen
            Product productToEdit = VareList.SelectedItem as Product;
            Console.WriteLine(productToEdit.Id);
            //Send det markerede objekt videre til siden hvor den kan redigeres
            EditProduct editProduct = new EditProduct(productToEdit);
            editProduct.Show();
        }

        private void VareList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ProductTableGenerator() {
            List<Product> productGetAllList = client.GetAll();
            foreach(var item in productGetAllList){
                VareList.Items.Add(item.Name);
            }
        } 

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VareList.Items.Clear();
            Product p = client.Get(Convert.ToInt32(searchProductTextField.Text));
            VareList.Items.Add(p.Name);
        }
    }
}
