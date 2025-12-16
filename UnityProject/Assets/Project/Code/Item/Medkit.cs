using Project.Code.Services.Health.Player;
using UnityEngine;

namespace Project.Code.Item {
    [System.Serializable]
    public class Medkit : Item {
        private readonly IServiveHealthPlayer _ServivehealthPlayer; 

        public Medkit(float Health, IServiveHealthPlayer ServivehealthPlayer) {
            _ServivehealthPlayer = ServivehealthPlayer;
            _HealAmount = Health;
        }
        public override void OnItem() {
            _ServivehealthPlayer.HealPlayer(_HealAmount);
            Debug.Log("Medkit used: Health restored!");
        }

        private float _HealAmount;
    }
}