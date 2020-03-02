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
using System.Data.Entity;

namespace BiddingMaintenance_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Define connection object context (see app.config for name)
        dmBiddingEntities context = new dmBiddingEntities();


        CollectionViewSource systemViewSource;
        CollectionViewSource stageViewSource;
        CollectionViewSource bidsViewSource;
        CollectionViewSource stagesViewSource;

        public MainWindow()
        {
            InitializeComponent();

            systemViewSource = ((CollectionViewSource)(FindResource("systemViewSource")));
            stageViewSource = ((CollectionViewSource)(FindResource("stageViewSource")));
            bidsViewSource = ((CollectionViewSource)(FindResource("systembidsViewSource")));
            stagesViewSource = ((CollectionViewSource)(FindResource("systemstagesViewSource")));
            
            //DataContext = this;
            DataContext = new dmBiddingMainWindowViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            context.systems.Load(); //this refers to variable "systems" contents, defined in |DMBidding_EF_1.Context.cs as dmBiddingEntities.systems
            context.stages.Load();
            System.Windows.Data.CollectionViewSource systemViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("systemViewSource")));
            System.Windows.Data.CollectionViewSource stageViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("stageViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // systemViewSource.Source = [generic data source]
            systemViewSource.Source = context.systems.Local;
            stageViewSource.Source = context.stages.Local;
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
