namespace Project.Code.Player {
    public class Health {
        private float _currentHealth;
        private float _maxHealth;

        public Health(float maxHealth) {
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
        }
        public void TakeDamage(float damage) {
            _currentHealth -= damage;
            if (_currentHealth < 0) _currentHealth = 0;
        }
        public void Heal(float amount) {
            _currentHealth += amount;
            if (_currentHealth > _maxHealth) _currentHealth = _maxHealth;
        }

        public float CurrentHealth => _currentHealth;
        public float MaxHealth => _maxHealth;
    }
}