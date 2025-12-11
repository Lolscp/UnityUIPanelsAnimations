using Project.Code.Enitities.EntityPlayer;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Code.UI.Player {
    public sealed class HealthBar : MonoBehaviour {
        [SerializeField] private Image Image;

        public void UpdateHealth(float value) {
            Image.fillAmount = _MaxHealth / value;
        }
        public void Inti(IHealth health,float MaxHealth) {
            _Health.UpdatedHealEvent += UpdateHealth;
            _Health.UpdatedDamageEvent += UpdateHealth;

            _MaxHealth = MaxHealth;
        }
        private void OnEnable() {
            _Health.UpdatedHealEvent += UpdateHealth;
            _Health.UpdatedDamageEvent += UpdateHealth;
        }
        private void OnDisable() {
            _Health.UpdatedHealEvent -= UpdateHealth;
            _Health.UpdatedDamageEvent -= UpdateHealth;
        } 
        private IHealth _Health;
        private float _MaxHealth;
    }
}