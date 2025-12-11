using Project.Code.Enitities.EntityPlayer;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Code.Managers.Analyzer {
    public class ManagersAnalyzer : MonoBehaviour {
        private Dictionary<Type,int> ILstTypes = new Dictionary<Type, int>();

        public void Inti<T>(IHealth health) {
            var Type = typeof(T);
            Health = health;

            Health.GetTypeUpdateHealthEvent += AddIlthType;

            Debug.Log(Type);
        }
        private void AddIlthType(Type type) {
            if (ILstTypes.ContainsKey(type)) ILstTypes[type]++;
            else ILstTypes.Add(type, 1);
        }

        public IHealth Health { get; private set; }
    }
}
