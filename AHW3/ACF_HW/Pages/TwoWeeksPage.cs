using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;

namespace ACF_HW.Pages
{
    using _ = TwoWeeksPage;

    [Url("2-weeks")]
    class TwoWeeksPage : Page<_>
    {
        public H1<_> PageInfo { get; private set; }

        [ScrollUsingScrollIntoView()]
        public Link<_> AverageTemp { get; private set; }


    }
}
