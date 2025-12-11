using UnityEngine;

namespace Project.Code.Enitities.EntityPlayer {
    public sealed class Player : MonoBehaviour {
        public Health Health { get; private set; }

        public Player(Health health) {
            Health = health;
        }

        private void OnDisable() {
            Health.DeleteEvents();
        }
        private void OnEnable() {
            Health.SubscribeEvents();
        }
    }
}
