using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Data.Entity;
using System.Globalization;


namespace BiddingMaintenance_SQL
{
     class dmBiddingMainWindowViewModel : INotifyPropertyChanged
    {
        dmBiddingEntities ctx = new dmBiddingEntities();
        //dmBiddingEntities context = new dmBiddingEntities();
        CollectionViewSource bidsViewSource;
        //###################
        /*public class DistinctConverter : IValueConverter
        {
            private List<stage> xStages = new List<stage>();
            //dmBiddingEntities ctx = new dmBiddingEntities();
            //CollectionViewSource bidsViewSource;
            private List<stage> GetDistinctStages()
            {
                dmBiddingEntities _ctx = new dmBiddingEntities();
                
                xStages = (from StageDescription in _ctx.stages select StageDescription).ToList();
                return xStages;
            }
            public object Convert(
                object value, Type targetType, object parameter, CultureInfo culture)
            {
                //var values = value as IEnumerable<Type>;
                //var values = value as CollectionView;
                var _values = GetDistinctStages();
                if (_values == null)
                    return null;
                //return values.Cast<object>().Distinct();
                return _values;
            }

            public object ConvertBack(
                object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotSupportedException();
            }
        }
        */
        //###################
        public dmBiddingMainWindowViewModel()
        {

            //FillStages();
            //**NOTE: Application.Curremt.FindResource DOES NOT WORK: You must define the more precise location...in this case MainWindow.
            bidsViewSource = (CollectionViewSource)Application.Current.MainWindow.FindResource("systembidsViewSource");
            bidsViewSource.Filter += new FilterEventHandler(ShowSelectedStageFilter);


        }
        private void ShowSelectedStageFilter(object sender, FilterEventArgs e)
        {

        }

        /*private void FillStages()
        {
            var q = (from a in ctx.stages select a).ToList();
        }

        private List<stage> _stages;

        public List<stage> Stages
        {
            get { return _stages; }
            set {
                _stages = value;
                NotifyPropertyChanged();
            }
        }
        public List<stage> xStages = new List<stage>();
        public List<stage> GetDistinctStages()
        { 
            xStages = (from StageDescription in ctx.stages select StageDescription).ToList();
            return xStages;
        }
        */
        /*private void FillSystems()
       {
           var q = (from a in ctx.systems
                    select a).ToList();
           this.Systems = q;
       }
       private List<System> _systems;
       public List<System> Systems
       {
           get
           {
               return _systems;
           }
           set
           {
               _systems = value;
               NotifyPropertyChanged();
           }
       }

       private System _selectedSystemr;
       public System SelectedSystem
       {
           get
           {
               return _selectedSystem;
           }
           set
           {
               _selectedSystem = value;
               NotifyPropertyChanged();
               FillBid();
           }
       }

       private void FillBid()
       {
           System system = this.SelectedSystem;

           var q = (from bid in ctx.bids
                    orderby bid.StageRef
                    where bid.SystemRef== System.SystemId
                    select book).ToList();

           this.Bids = q;
       }

       private List<Bid> _bids;
       public List<Bid> Bids
       {
           get
           {
               return _bids;
           }
           set
           {
               _bids = value;
               NotifyPropertyChanged();
           }
       }

       private Bid _selectedBid
       public Bid SelectedBid
       {
           get
           {
               return _selectedBid;
           }
           set
           {
               _selectedBid = value;
               NotifyPropertyChanged();
           }
       }*/
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
 
}