using Project.Code.Enitities.EntityPlayer;
using UnityEngine;

namespace Project.Code.Managers.EntityPlayer {
    public sealed class ManagerPlayer : MonoBehaviour {
        [Header("")]
        [SerializeField] private Player _Player;

        public static ManagerPlayer Instance { get; private set; }

        public void Inti<T>(IHealth health) {
            var Type = typeof(T);
            Health = health;
            _Player.Health.PlayerDiedEvent += DiePlayer;
            Debug.Log(Type);
        }
        private void DiePlayer() => Debug.Log("Player Died");

        public IHealth Health { get; private set; }
    }
}