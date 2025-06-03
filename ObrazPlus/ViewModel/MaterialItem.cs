using ObrazPlus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazPlus.ViewModel
{
    public class MaterialItem
    {
        public Materials materials { get; set; }

        public string Title { get; set; }
        public string materialType { get; set; }
        public string minQuantity { get; set; }
        public string quantityInStock { get; set; }
        public string unitPrice { get; set; }
        public string requiredQuantity { get; set; }
        public int Id { get; set; }

        public MaterialItem(Materials material)
        {
            this.Title = material.Title;
            this.Id = Convert.ToInt32(material.Id);
            this.materialType = material.Material_type.Title;
            this.minQuantity = $"Минимальное количество: {material.MinQuantity}";
            this.quantityInStock = $"Количество на складе: {material.QuantityInStock}";
            this.unitPrice = $"Цена: {material.UnitPrice}р/{material.StorageUnits.Title} | {material.QuantityInPackage}";
            var count = material.Material_products.ToList().Sum((product) => product.RequiredQuantity);
            this.requiredQuantity = $"Требуемое количество: {count}";
        }
    }
}
