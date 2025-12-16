using Project.Code.Player.Mediator;
using Project.Code.Services.Health.Player;
using UnityEngine;

namespace Project.Code.Test {
    public class PlayerDamageTest : MonoBehaviour {
        private ServiveHealthPlayer _ServiveHealthPlayer;

        public void Inti(Player.Player player) {
            _ServiveHealthPlayer = new ServiveHealthPlayer(player.HealthBehaviour);
        }

        public void DamegerPlayer(float Value) => _ServiveHealthPlayer.DamagePlayer(Value);
        public void HealPlayer(float Value) => _ServiveHealthPlayer.HealPlayer(Value);

        public void DamegerPlayerT() => _ServiveHealthPlayer.DamagePlayer(ValueDamage);
        public void HealPlayerT() => _ServiveHealthPlayer.HealPlayer(ValueHeal);

        public float ValueHeal;
        public float ValueDamage;

        private IMediator<PlayerDamageTest> IMediator;
    }
}