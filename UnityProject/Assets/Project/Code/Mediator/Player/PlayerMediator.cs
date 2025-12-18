using Project.Code.Player;
using Project.Code.UI.Player;
using System;
using UnityEngine;

namespace Project.Code.Mediator.Player {
    public class PlayerMediator : MonoBehaviour , IMediatorHealth<float> {

        public float GetValueHealth() => HealthBehaviour.CurrentHealth;
        public void UndateHealth() => HealthBar.UpdateHealth(HealthBehaviour.CurrentHealth);
        public void Init(HealthBehaviour healthBehaviour) {
            HealthBehaviour = healthBehaviour;
            HealthBar.Inti();
        }

        [SerializeField] public HealthBar HealthBar;
        public HealthBehaviour HealthBehaviour;
    }
}