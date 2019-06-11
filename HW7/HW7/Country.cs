namespace HW7
{
    public class Country
    {
        public string Name;
        public bool IsTelenorSupported;
        public Country(string name, bool isTelenorSupported = false)
        {
            Name = name;
            IsTelenorSupported = isTelenorSupported;
        }
    }
}
