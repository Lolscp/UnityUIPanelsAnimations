using System;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Code.Services {
    public class ServiceLocator {
        private Dictionary<Type,object> Services = new Dictionary<Type, object>();

        public void RegisterService<T>(T service) where T : class {
            var type = typeof(T);
            if (Services.ContainsKey(type)) {
                Debug.LogWarning($"Service of type {type} is already registered. Overwriting the existing service.");
            }
            Services[type] = service;
        }
        public T GetService<T>() where T : class {
            var type = typeof(T);
            if (Services.TryGetValue(type, out var service)) {
                return service as T;
            }
            Debug.LogError($"Service of type {type} is not registered.");
            return null;
        }
        public void UnregisterService<T>() where T : class {
            var type = typeof(T);
            if (Services.ContainsKey(type)) {
                Services.Remove(type);
            } else {
                Debug.LogWarning($"Service of type {type} is not registered. Cannot unregister.");
            }
        }
    }
}