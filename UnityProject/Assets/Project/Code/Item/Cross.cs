using UnityEngine;

namespace Project.Code.Item {
    public class Cross : Item {
        public override void OnItem() {
            Debug.Log("Cross used: You feel protected!");
        }
    }
}
