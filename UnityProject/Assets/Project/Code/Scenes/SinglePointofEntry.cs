using UnityEngine;
using Project.Code.Managers.EntityPlayer;
using Project.Code.Managers.Analyzer;
using Project.Code.Managers.EntityPlayer.Health;

namespace Project.Code.Scenes {
    public class SinglePointofEntry : MonoBehaviour {
        public void Awake() {
            IntiAllManagres();
        }

        private void IntiAllManagres() {
            _ManagerPlayer.Inti<SinglePointofEntry>(new HealthBehaviour());
        }
        [Header("Managers")]
        [SerializeField] private ManagerPlayer _ManagerPlayer;
        [SerializeField] private ManagersAnalyzer ManagersAnalyzer;
    }
}