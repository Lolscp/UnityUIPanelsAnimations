using Project.Code.Mediator;
using Project.Code.Mediator.Player;
using Project.Code.Player;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Code.UI.Player {
    public sealed class HealthBar : MonoBehaviour {
        [SerializeField] private Image Image;

        public void UpdateHealth(float value) {
            Image.fillAmount = _MaxHealth / value;
        }
        public void Inti() {

        }

        private IMediatorHealth<float> _IMediator;
        private float _MaxHealth;
    }
}