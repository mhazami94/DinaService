using System;
using System.Collections.Generic;
using System.Text;

namespace Stablex.DataStructure.ModelView
{
    public class ChartsViewModel
    {
        public BlogChartsViewModel Blogs { get; set; }
    }

    public class BlogChartsViewModel
    {
        public string ViewsData { get; set; }

        public string StatusData { get; set; }

    }

}
