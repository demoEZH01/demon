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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            
            DataContext = new MaterialViewModel();
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            if (MaterialListBox.SelectedValue == null) return;

            int selectedMaterialId = Convert.ToInt32(MaterialListBox.SelectedValue);
            if (selectedMaterialId == 0) return;

            var editWindow = new EditMaterialWindow(selectedMaterialId);
            bool? result = editWindow.ShowDialog();

            if (result == true)
            {
                // Обновляем список после редактирования
                var vm = DataContext as MaterialViewModel;
                vm?.LoadMaterials();
            }
            // Сбрасываем выбор (опционально)
            MaterialListBox.SelectedIndex = -1;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddMaterialWindow();
            if (dialog.ShowDialog() == true) {
                var vm = DataContext as MaterialViewModel;
                vm.LoadMaterials();
            }
        }
    }
}
