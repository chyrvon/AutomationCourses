namespace HW6
{
    public class ColorLamp : Lamp
    {
        public string ColorsLamp { get; set; }

        public ColorLamp(int indexNumber, string colorsLamp) : base (indexNumber)
        {
            ColorsLamp = colorsLamp;
        }
    }
}
