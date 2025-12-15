using Project.Code.Player;
using Project.Code.Player.Mediator;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Code.UI.Player {
    public sealed class HealthBar : MonoBehaviour {
        [SerializeField] private Image Image;
        private IMediator<Project.Code.Player.Player> mediator;

        public void UpdateHealth(float value) {
            Image.fillAmount = _MaxHealth / value;
        }
        //public void Inti(float MaxHealth) {
        //    _Health.UpdatedHealEvent += UpdateHealth;
        //    _Health.UpdatedDamageEvent += UpdateHealth;

        //    _MaxHealth = MaxHealth;
        //}
        //private void OnEnable() {
        //    _Health.UpdatedHealEvent += UpdateHealth;
        //    _Health.UpdatedDamageEvent += UpdateHealth;
        //}
        //private void OnDisable() {
        //    _Health.UpdatedHealEvent -= UpdateHealth;
        //    _Health.UpdatedDamageEvent -= UpdateHealth;
        //} 
        private HealthBehaviour _Health;
        private float _MaxHealth;
    }
}