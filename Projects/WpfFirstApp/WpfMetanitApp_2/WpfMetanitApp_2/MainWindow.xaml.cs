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

namespace WpfMetanitApp_2

{

    public class Phone
{
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"Смартфон {this.Name}; цена: {this.Price}";
    }
}
public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
    }
}
