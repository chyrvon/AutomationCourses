namespace HW6
{
    enum ColorMy
    {
        Red = 1,
        Yellow,
        Green,
        Blue
    }

    public class ColorLamp
    {
        public int IndexNumber { get; set; }
        public string ColorsLamp { get; set; }

        public ColorLamp(int indexNumber, string colorsLamp)
        {
            IndexNumber = indexNumber;
            ColorsLamp = colorsLamp;
        }

        public string GetStatusLamp(bool currentEvenMinute)
        {

            if (IndexNumber % 2 == 0 && currentEvenMinute)
            {
                return "On";
            }
            else
            {
                return "Off";
            }
        }
    }
}
