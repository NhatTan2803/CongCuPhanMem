using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeType
{
    public abstract class Bee
    {

        public virtual string Type { get; protected set; }

        public virtual float Health { get; protected set; }

        protected int HealthLimit { get; set; }

        public virtual bool Alive
        {
            get
            {
                return (this.Health > this.HealthLimit);
            }
        }

        public virtual void Damage(int damage)
        {
            if (this.Alive && damage > 0 && damage < 100)
            {
                this.Health -= damage;
            }
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }

        protected Bee(string type, int healthLimit)
        {
            this.Type = type;
            this.Health = 100;
            this.HealthLimit = healthLimit;
        }
    }
}
