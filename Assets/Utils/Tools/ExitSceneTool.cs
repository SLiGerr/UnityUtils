using Movement;
using UnityEngine;

namespace Tools
{
    public class ExitSceneTool : MonoBehaviour
    {
#if UNITY_EDITOR
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && Input.GetKeyDown(KeyCode.LeftShift))
            {
                Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
#endif
    }
}