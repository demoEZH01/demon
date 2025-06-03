using ObrazPlus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazPlus.ViewModel
{
    public class AddMaterialViewModel
    {
        public List<Material_type> material_Types = new List<Material_type>();
        public List<Material_type> Material_types{
            get{ return material_Types; }
            set{ material_Types = value; }
        }

        public List<StorageUnits> storageUnits = new List<StorageUnits>();
        public List<StorageUnits> StorageUnits
        {
            get { return storageUnits; }
            set { storageUnits = value; }
        }
        public AddMaterialViewModel() {
            LoadComboboxes();
        }

        private void LoadComboboxes()
        {
            try
            {
                using (var db = new MaterialDBEntities()){
                    Material_types = db.Material_type.ToList();
                    StorageUnits = db.StorageUnits.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
