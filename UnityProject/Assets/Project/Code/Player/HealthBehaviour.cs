using System;

namespace Project.Code.Player {
    public class HealthBehaviour {
        private Health _health;

        public HealthBehaviour(float maxHealth) {
            _health = new Health(maxHealth);
        }
        public void TakeDamage(float damage) {
            _health.TakeDamage(damage);
            if (_health.CurrentHealth <= 0) PlayerDeathEvent?.Invoke();
        }
        public void Heal(float amount) => _health.Heal(amount);
        
        public float CurrentHealth => _health.CurrentHealth;
        public float MaxHealth => _health.MaxHealth;

        public event Action PlayerDeathEvent;
    }
}