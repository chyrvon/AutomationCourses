using System;

namespace HW6
{
    public class SimpleGarland : Garland<Lamp>
    {
        public SimpleGarland(int garlandLength) : base(garlandLength)
        {
            for (int i = 0; i < garlandLength; i++)
            {
                _garland[i] = new Lamp(i);
            }
        }
    }
}


