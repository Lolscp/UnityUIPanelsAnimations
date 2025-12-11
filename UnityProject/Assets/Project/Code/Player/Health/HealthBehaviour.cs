using Project.Code.Enitities.EntityPlayer;
using System;

namespace Project.Code.Managers.EntityPlayer.Health {
    public class HealthBehaviour : IHealth {
        public void Heal<T>(float value) {
            var Type = typeof(T);
            UpdatedHealEvent?.Invoke(value);
            GetTypeUpdateHealthEvent?.Invoke(Type);
        }
        public void TakeDamage<T>(float value) {
            var Type = typeof(T);
            UpdatedDamageEvent?.Invoke(value);
            GetTypeUpdateHealthEvent?.Invoke(Type);
        }

        public event Action<float> UpdatedHealEvent;
        public event Action<float> UpdatedDamageEvent;
        public event Action<Type> GetTypeUpdateHealthEvent;
    }
}