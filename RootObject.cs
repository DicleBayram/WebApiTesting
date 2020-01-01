using System.Collections.Generic;

namespace Stylelabs.MQA.WebApiTesting.Entities
{
    public class RootObject
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
        public City city { get; set; }
    }
}
