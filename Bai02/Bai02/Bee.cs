using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    public abstract class Bee
    {
        public virtual int Type { get; set; }
        public virtual string Name { get; set; }
        public virtual float Health { get; set; }
        public virtual int defense { get; set; }
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
            if(this.Alive && damage >0 && damage <100)
            {
                this.Health -= (damage - this.defense);
                if (this.Health > 100)
                    this.Health = 100;
            }
            if(this.Health <0)
            {
                this.Health = 0;
            }
            if(this.Alive == false)
            {
                this.Health = 0;
            }
        }
        public virtual void WorkDroreDamage(int damage)
        {
            if(this.Alive && damage > 0 && damage <100)
            {
                this.Health -= Math.Abs(Convert.ToInt32((damage * 0.5) - this.defense));
                this.Health -= (damage - this.defense);
                if (this.Health > 100)
                    this.Health = 100;
            }
            if(this.Health<0)
            {
                this.Health = 0;
            }
            if(this.Alive == false)
            {
                this.Health = 0;
            }
        }
        protected Bee(int type, string name, int healLimit)
        {
            this.Name = name;
            this.Type = type;
            this.Health = 100;
            this.HealthLimit = healLimit;
        }

        internal void Defense(int def)
        {
            throw new NotImplementedException();
        }
    }
}
