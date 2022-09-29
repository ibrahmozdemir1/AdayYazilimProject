using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Trains
    {
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public List<Cars> Cars { get; set; }    
    }
}
