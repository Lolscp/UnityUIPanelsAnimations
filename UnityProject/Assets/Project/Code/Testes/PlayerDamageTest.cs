using Project.Code.Player;
using Project.Code.Player.Mediator;
using UnityEngine;

namespace Project.Code.Test {
    public class PlayerDamageTest : MonoBehaviour {
        private Player.Player Player;

        public void Inti(Player.Player player) => Player = player;

        public void DamegerPlayer(float Value) => IMediator.Sender<float>(this, Value);

        private IMediator<PlayerDamageTest> IMediator;
    }
}