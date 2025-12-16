namespace Project.Code.Services.Health.Player {
    public class ServiveHealthPlayer : IServiveHealthPlayer {
        private Code.Player.Player Player;
        private Code.Player.HealthBehaviour _HealthBehaviour;

        public void HealPlayer(float healAmount) {
            _HealthBehaviour.Heal(healAmount);
        }
        public void DamagePlayer(float damageAmount) {
            _HealthBehaviour.TakeDamage(damageAmount);
        }
        public void KillPlayer() {
            _HealthBehaviour.TakeDamage(_HealthBehaviour.CurrentHealth);
        }
        public ServiveHealthPlayer(Code.Player.HealthBehaviour HealthBehaviour) => _HealthBehaviour = HealthBehaviour;
    }
}