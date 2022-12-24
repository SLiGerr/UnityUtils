using Sirenix.Utilities;
using UnityEngine;

namespace Utils
{
    public class Parent
    {
        public bool Initialized => !parent.SafeIsUnityNull();

        private readonly string name;

        private Transform parent;
        private Transform parentForThisParent;

        public Parent(string name, Transform spawnUnder = null)
        {
            this.name           = name;
            parentForThisParent = spawnUnder;
        }

        public Transform Transform => parent.SafeIsUnityNull() ? GetNewParent() : parent;

        private Transform GetNewParent()
        {
            var newParent = new GameObject(name).transform;
            newParent.SetParent(parentForThisParent);
            parent = newParent;
            return newParent;
        }

        public void SetParent(Transform p) => Transform.SetParent(p);
        
        public static implicit operator Transform(Parent parent) => parent.Transform;
    }
}