using UnityEngine;


namespace Balthazariy.Utilities
{
    public class DontDestroyUtility : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}