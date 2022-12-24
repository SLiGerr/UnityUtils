#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Utils.Editor
{
    public class FitAnimationsName : AssetPostprocessor
    {
        private void OnPostprocessAnimation(GameObject g, AnimationClip c) => c.name = g.name;
    }
}
#endif