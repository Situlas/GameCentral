using System;
using StorageGUI.Extentions;
using StorageGUI.IGameCentralServiceReference1;
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
    /// Interaction logic for EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {


        Product productToUpdate = null;
        IGameCentralServiceReference1.IGameCentralServiceProduct client = new IGameCentralServiceReference1.GameCentralServiceProductClient();

        public EditProduct(Product productToEdit)
        {
            InitializeComponent();
            productToUpdate = productToEdit;
            productName.Text = productToEdit.Name;
            productPrice.Text = productToEdit.Price.ToString();
            productDescription.Text = productToEdit.Description;
            productStock.Text = productToEdit.Stock.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //All information should be changed in the object
            productToUpdate.Name = productName.Text;
            productToUpdate.Price = Convert.ToDouble(productPrice.Text);
            productToUpdate.Description = productDescription.Text;
            productToUpdate.Stock = Convert.ToInt32 (productStock.Text);
            //Call update method from client
            client.Update(productToUpdate);
            //Call a messagebox.show(Text) with the corrosponding text best suited for the scenario
            MessageBox.Show("Ændringer til produktet: " + productToUpdate.Name + " er blevet gemt i databasen");
            //Call close() method to close window and end class operation
            Close();
        }
    }
}
