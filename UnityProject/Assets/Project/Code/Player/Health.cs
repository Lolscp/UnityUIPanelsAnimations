using System;

namespace Project.Code.Enitities.EntityPlayer {
    public sealed class Health {
        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }

        public Health(float maxHealth,bool immortality,IHealth health) {
            _IHealth = health;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Immortality = immortality;

            _IHealth.UpdatedHealEvent += Heal;
            _IHealth.UpdatedDamageEvent += TakeDamage;
        }
        private void TakeDamage(float damage) {
            CurrentHealth -= damage;
            PlayerEceivedDamageEvent?.Invoke(damage, CurrentHealth);
            if (CurrentHealth < 0) {
                if (Immortality == false) PlayerDiedEvent?.Invoke();
                CurrentHealth = 0;
            }
        }
        private void Heal(float amount) {
            CurrentHealth += amount;
            PlayerRestoredHealthEvent?.Invoke(amount, CurrentHealth);
            if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;            
        }
        public void DeleteEvents() {
            _IHealth.UpdatedHealEvent -= Heal;
            _IHealth.UpdatedDamageEvent -= TakeDamage;
        }
        public void SubscribeEvents() {
            _IHealth.UpdatedHealEvent += Heal;
            _IHealth.UpdatedDamageEvent += TakeDamage;
        }
        private IHealth _IHealth;
        public bool Immortality { get; private set; }

        public event Action<float, float> PlayerEceivedDamageEvent;
        public event Action<float, float> PlayerRestoredHealthEvent;
        public event Action PlayerDiedEvent;
    }
}
