using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using bikeHelper.Models;
namespace bikeHelper.Services
{
    public class BikesDataAccess
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public ObservableCollection<Bike> Bikes { get; set; }

        public BikesDataAccess()
        {
            database = DependencyService.Get<IDatabaseConnection>().DbConnection();
            database.CreateTable<Bike>();

            this.Bikes = new ObservableCollection<Bike>(database.Table<Bike>());

            if (!database.Table<Bike>().Any())
            {
                AddNewBike();
            }
        }

        public void AddNewBike()
        {
            this.Bikes.Add(new Bike
            {
                Name = "Canyon",
                Speed = "55 km/h",
                GearRatio = "50:12"
            });
        }

        public IEnumerable<Bike> GetFilteredBikes(string name)
        {
            lock (collisionLock)
            {
                var query = from cust in database.Table<Bike>()
                            where cust.Name == name
                            select cust;
                return query.AsEnumerable();
            }
        }

        public IEnumerable<Bike> GetFilteredBikes()
        {
            lock (collisionLock)
            {
                return database.Query<Bike>("SELECT * FROM Item Where Name = 'Felt'").AsEnumerable();
            }
        }

        public Bike GetBike(int id)
        {
            lock (collisionLock)
            {
                return database.Table<Bike>().FirstOrDefault(bike => bike.Id == id);
            }
        }

        public int SaveBike(Bike bikeInstance)
        {
            lock (collisionLock)
            {
                if(bikeInstance.Id != 0)
                {
                    database.Update(bikeInstance);
                    return bikeInstance.Id;
                }
                else
                {
                    database.Insert(bikeInstance);
                    return bikeInstance.Id;
                }
            }
        }

        public void SaveAllBikes()
        {
            lock (collisionLock)
            {
                foreach (var bikeInstance in this.Bikes)
                {
                    if(bikeInstance.Id != 0)
                    {
                        database.Update(bikeInstance);
                    }
                    else
                    {
                        database.Insert(bikeInstance);
                    }
                }
            }
        }

        public int DeleteBike(Bike bikeInstance)
        {
            var id = bikeInstance.Id;
            if(id != 0)
            {
                lock (collisionLock)
                {
                    database.Delete<Bike>(id);
                }
            }
            this.Bikes.Remove(bikeInstance);
            return id;
        }

        public void DeleteAllBikes()
        {
            lock (collisionLock)
            {
                database.DropTable<Bike>();
                database.CreateTable<Bike>();
            }
            this.Bikes = null;
            this.Bikes = new ObservableCollection<Bike>(database.Table<Bike>());
        }
    }
}
