using SQLite;
using System.ComponentModel;

namespace bikeHelper.Models
{
    [Table("Bikes")]
    public class Bike : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        private string _name;
        [NotNull]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string _speed;
        public string Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                this._speed = value;
                OnPropertyChanged(nameof(Speed));
            }
        }
        private string _gearRatio;
        public string GearRatio
        {
            get
            {
                return _gearRatio;
            }
            set
            {
                this._gearRatio = value;
                OnPropertyChanged(nameof(GearRatio));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}