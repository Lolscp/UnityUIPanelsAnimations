using UnityEngine;

namespace Project.Code.Enemies.Factories {
    public sealed class FactorieZombie : FactorieEnemie {

        public void Inti(Player.Player player) {
            _player = player;
        }
        //[Header("")]
        //[SerializeField] private float _zombieHealth;
        //[Header("")]
        //[SerializeField] private Medkit _medkitPrefab;
    }
}