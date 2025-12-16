using Project.Code.Enemies.Factories;
using Project.Code.Test;
using Project.Code.Testes;
using UnityEngine;

namespace Project.Code.Scenes {
    public class SinglePoint : MonoBehaviour {

        private void IntiAllManagers() {

        }
        private void IntiAllFactorie() { }
        private void Test() {
            _FactoriePlayer.Inti(_player);
            _FactoriePlayer.Creation();
            _PlayerDamageTest.Inti(_player);
        }
        private void Awake() {
            Test();
        }

        [Header("Testes")]
        [SerializeField] private PlayerDamageTest _PlayerDamageTest;
        [SerializeField] private FactoriePlayer _FactoriePlayer;
        [Header("Managers")]
        [SerializeField] private ManegerFactoriesEnemie _manegerFactoriesEnemie;
        [Header("Factories")]
        [SerializeField] private FactorieZombie _FactorieZombie;
        [Header("Gameplay")]
        [SerializeField] private Player.Player _player;
    }
}