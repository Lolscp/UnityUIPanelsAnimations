using Project.Code.Player;
using UnityEngine;

namespace Project.Code.Testes {
    public class FactoriePlayer : MonoBehaviour {
        private Player.Player _player;
        public float _MaxHealth;

        public void Inti(Player.Player player) => _player = player;
        public void Creation() => _player.Inti();
    }
}
