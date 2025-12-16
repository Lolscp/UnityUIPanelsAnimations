using Project.Code.UI.Player;
using System;
using System.Collections.Generic;

namespace Project.Code.Player.Mediator {
    public class PlayerMediator : IMediator<Player> {
        private Dictionary<Player, Action<float>> PlayerDictionary = new Dictionary<Player, Action<float>>();



        public void Sender<T1>(Player obj,T1 ActionEvent) {
            
        }

        private Player Player;
        private HealthBehaviour HealthBehaviour;
        private HealthBar HealthBar;
    }
}