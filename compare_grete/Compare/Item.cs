using System;
namespace Compare
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Distance { get; set; }
        public int Speed { get; set; }

        private string newName = "New Input:";
        public string NewName
        {
            get { return newName; }
            set { if (value != null) newName = value; }
        }

        private int newDistance = 7;
        public int NewDistance
        {
            get { return newDistance; }
            set { if (value != 0) newDistance = value; }
        }

        private int newSpeed = 15;
        public int NewSpeed
        {
            get { return newSpeed; }
            set { if (value != 0) newSpeed = value; }
        }

        public string NewData { get { return NewName + " Distance: " + NewDistance.ToString() + " Speed: " + NewSpeed.ToString(); } }
    }
}