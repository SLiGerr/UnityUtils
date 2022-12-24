using Lean.Pool;
using UnityEngine;

namespace Utils
{
    public static class PoolTool
    {
        public static LeanGameObjectPool CreatePoolForPrefab(GameObject prefab, Transform poolParent)
        {
            var pool = default(LeanGameObjectPool);
            if (LeanGameObjectPool.TryFindPoolByPrefab(prefab, ref pool) == false)
            {
                pool                  = new GameObject("LeanPool (" + prefab.name + ")").AddComponent<LeanGameObjectPool>();
                pool.Prefab           = prefab;
                pool.transform.parent = poolParent;
            }
            return pool;
        }
    }
}