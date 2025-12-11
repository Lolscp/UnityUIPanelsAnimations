using System;

namespace Project.Code.Enitities.EntityPlayer  {
    public interface IHealth { 
        public void TakeDamage<T>(float value);
        public void Heal<T>(float value);

        public event Action<float> UpdatedHealEvent;
        public event Action<float> UpdatedDamageEvent;
        public event Action<Type> GetTypeUpdateHealthEvent;
    }
}
