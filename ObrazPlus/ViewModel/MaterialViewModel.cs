using ObrazPlus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;

namespace ObrazPlus.ViewModel
{
    public class MaterialViewModel
    {
        ObservableCollection<MaterialItem> materialList = new ObservableCollection<MaterialItem>();
        public ObservableCollection<MaterialItem> MaterialList
        {
            get { return materialList; }
            set { materialList = value; }
        }

        public MaterialViewModel()
        {
            LoadMaterials();
        }

        public void LoadMaterials()
        {
            try
            {
                using (var db = new MaterialDBEntities())
                {
                    MaterialList.Clear();
                    var materials = db.Materials.ToList();
                    foreach (var material in materials)
                    {
                        MaterialList.Add(new MaterialItem(material));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка", $"Ошибка: {e.Message}", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
