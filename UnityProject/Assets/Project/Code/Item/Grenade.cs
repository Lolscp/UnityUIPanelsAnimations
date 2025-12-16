using UnityEngine;

namespace Project.Code.Item {
    public class Grenade : Item {
        public Grenade(float damage) {
            _Damage = damage;
        }
        public override void OnItem() {
            Debug.Log($"Grenade used: Explosion deals {_Damage} damage!");
        }
        private float _Damage;
    }
}