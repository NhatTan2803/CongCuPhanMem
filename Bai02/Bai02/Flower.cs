using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    public class Flower
    {
        public virtual string FlowerName { get; set; }
        public bool poison { get; set; }
        public virtual int LowerType { get; set; }
        public int pollen { get; set; }
        public virtual bool Death
        {
            get
            {
                return (this.pollen == 0);
            }
        }
    }
}
