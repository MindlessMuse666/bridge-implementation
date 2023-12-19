using System;
using UnityEngine;

namespace Iron_Chest
{
    public class OpenChest : MonoBehaviour
    {
        [SerializeField] private Chest _chest;
        [SerializeField] private Collider _playerCollider;

        private event Action _openChest;

        private void Awake()
        {
            _openChest += _chest.Open;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other == _playerCollider)
            {
                _openChest?.Invoke();
                _openChest -= _chest.Open;
            }
        }
    }
}