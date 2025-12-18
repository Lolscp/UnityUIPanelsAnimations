using Project.Code.Enemies.Factories;
using Project.Code.Test;
using Project.Code.Testes;
using UnityEngine;

namespace Project.Code.Scenes {
    public class SinglePointProject : MonoBehaviour {

        public void Awake() {
            // Factories Enemie
            // Gameplay
            _FactoriePlayer.Inti(_player);
            _FactoriePlayer.Creation();
            // Testes
            _PlayerDamageTest.Inti(_player);
        }




        [Header("Managers")]
        [SerializeField] private ManegerFactoriesEnemie _manegerFactoriesEnemie;
        [Header("Factories")]
        [SerializeField] private FactorieZombie _FactorieZombie;
        [Header("Gameplay")]
        [SerializeField] private Player.Player _player;
        [Header("Testes")]
        [SerializeField] private PlayerDamageTest _PlayerDamageTest;
        [SerializeField] private FactoriePlayer _FactoriePlayer;
    }
}