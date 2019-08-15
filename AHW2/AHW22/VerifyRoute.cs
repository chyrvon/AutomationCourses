using NUnit.Framework;
using System;
using System.Linq;

namespace AHW2
{
    public class VerifyRoute
    {
        public VerifyRoute()
        {
        }

        public VerifyRoute(string route, string departureStr, string arrivalStr)
        {
            string departureCity, arrivalCity;
            string[] words;
            route = route.ToLower();
            departureStr = departureStr.ToLower();
            arrivalStr = arrivalStr.ToLower();

            if (route.Length > 28)  //"Kyiv - Zhulyany (IEV) Copenhagen (CPH)";
            {
                route = route.Substring(0, route.Length - 6);
                words = route.Split(new char[] { '(', 'I', 'E', 'V', ')' });
            }
            else //"KYIV - ZHULYANY – COPENHAGEN";
            {
                words = route.Split(new char[] { '–' });
            }
            departureCity = words.First();
            arrivalCity = words.Last();
            departureCity = departureCity.Substring(0, departureCity.Length - 1);
            words = departureCity.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            departureCity = words[0];
            arrivalCity = arrivalCity.Substring(1);
            Assert.AreEqual(departureCity, departureStr);
            Assert.AreEqual(arrivalCity, arrivalStr);
        }
    }
}
