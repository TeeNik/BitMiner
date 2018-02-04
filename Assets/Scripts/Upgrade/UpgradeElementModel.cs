namespace Assets.Scripts.Upgrade
{
    public class UpgradeElementModel
    {

        public int Id;
        public string Title;
        public int Level;
        public double Price;
        public double Speed;

        public UpgradeElementModel()
        {

        }

        public UpgradeElementModel(int id, string title, int level, double price, double speed)
        {
            Id = id;
            Title = title;
            Level = level;
            Price = price;
            Speed = speed;
        }

    }
}
