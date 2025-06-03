using ObrazPlus.Model;
using ObrazPlus.ViewModel;
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

namespace ObrazPlus.View
{
    /// <summary>
    /// Логика взаимодействия для AddMaterialWindow.xaml
    /// </summary>
    public partial class AddMaterialWindow : Window
    {
        public Material_type _Material_Type;
        public StorageUnits _StorageUnits;
        public AddMaterialWindow()
        {
            InitializeComponent();
            DataContext = new AddMaterialViewModel();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new MaterialDBEntities()){
                    _Material_Type = TypeMaterial.SelectedItem as Material_type;
                    _StorageUnits = StorageUnitTB.SelectedItem as StorageUnits;
                    Materials materials = new Materials();
                    materials.Title = TitleMaterial.Text.Trim();
                    materials.MinQuantity = Convert.ToDecimal(MinQuantityTB.Text.Trim());
                    materials.MaterialTypeId = _Material_Type.Id;
                    materials.StorageUnitsId = _StorageUnits.Id;
                    materials.QuantityInStock = Convert.ToDecimal(QuantityInStockTB.Text.Trim());
                    materials.QuantityInPackage = Convert.ToDecimal(QuantityinPackage.Text.Trim());
                    materials.UnitPrice = Convert.ToDecimal(PriceTB.Text.Trim());
                    db.Materials.Add(materials);
                    db.SaveChanges();
                    DialogResult = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
