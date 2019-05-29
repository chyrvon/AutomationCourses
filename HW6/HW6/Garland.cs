namespace HW6
{
    public abstract class Garland
    {
        public const int DefaultNumberOfLamps = 10;


        public Lamp[] _garland;
        

        public Garland(int garlandLength)
        {
            _garland = new Lamp[garlandLength];
        }
        public abstract void ShowStatusGarland(bool currentEvenMinute);
    }
}
