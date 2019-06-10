namespace HW7
{
    public class Country
    {
        public string Name;
        public bool IsTelenorSupported;
        public Country()
        {
            Name = "";
            IsTelenorSupported = false;
        }

        public Country(string Name)
        {
            this.Name = Name;
        }
    }
}
