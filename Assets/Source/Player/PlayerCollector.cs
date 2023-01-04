using System;
using UnityEngine;

namespace Balthazariy.Player
{
    public class PlayerCollector : MonoBehaviour
    {
        public event Action<Collider> PlayerCollectEvent;

        private void OnTriggerEnter(Collider collider)
        {



            PlayerCollectEvent?.Invoke(collider);
        }
    }
}