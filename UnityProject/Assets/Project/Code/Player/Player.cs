using UnityEngine;

namespace Project.Code.Player {
    public class Player : MonoBehaviour {
        public HealthBehaviour HealthBehaviour { get; private set; }

        public void Inti(float MaxHealth) {
            HealthBehaviour = new HealthBehaviour(MaxHealth);
        }
        public void UpdateHealth() {
            Debug.Log($"Player Health: {HealthBehaviour.CurrentHealth}/{HealthBehaviour.MaxHealth}");
        }
    }
}