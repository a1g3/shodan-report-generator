using System.Collections.Generic;

namespace Report_Generation.ViewModels
{
    public class DisplaySection
    {
        public string Title { get; set; }
        public List<DisplayItem> DisplayItems { get; set; }

    }
    public class DisplayItem
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
}