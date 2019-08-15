using COE.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using ACF_HW.Pages;

namespace ACF_HW.Tests
{
    class TestFixture : UITestFixtureBase
    {
        [Test]
        public void TestMethod()
        {
            Go.To<TwoWeeksPage>()
                .PageTitle.Should.ContainSoft("Погода у Харкові на два тижні")
                .AverageTemp.Should.ExistSoft();
        }
    }
}
