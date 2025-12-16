using UnityEngine;

namespace Project.Code.Item {
    public class Tablet : Item {
        public Tablet(float energyBoost) {
            _EnergyBoost = energyBoost;
        }
        public override void OnItem() {
            Debug.Log($"Tablet used: Energy increased by {_EnergyBoost} points!");
        }
        private float _EnergyBoost;
    }
}