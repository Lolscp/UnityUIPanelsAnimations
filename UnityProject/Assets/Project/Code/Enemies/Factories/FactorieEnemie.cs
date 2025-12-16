using Project.Code.Services.Health.Player;
using UnityEngine;

namespace Project.Code.Enemies.Factories {
    public abstract class FactorieEnemie : MonoBehaviour {
        protected IServiveHealthPlayer _serviveHealthPlayer;
        protected Player.Player _player;

        protected virtual void IntiServiveHealthPlayer() {
            _serviveHealthPlayer = new ServiveHealthPlayer(_player.HealthBehaviour);
        }
    }
}