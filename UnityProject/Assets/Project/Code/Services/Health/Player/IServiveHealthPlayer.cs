namespace Project.Code.Services.Health.Player {
    public interface IServiveHealthPlayer {
        public void HealPlayer(float healAmount);
        public void DamagePlayer(float damageAmount);

        public void KillPlayer();
    }
}