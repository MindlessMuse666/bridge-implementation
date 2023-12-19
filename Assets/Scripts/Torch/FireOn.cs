using System;
using UnityEngine;

namespace Torch
{
    public class FireOn : MonoBehaviour
    {
        [SerializeField] private GameObject _fire;
        [SerializeField] private Collider _playerCollider;

        private event Action _fireOn;

        private void Awake()
        {
            _fireOn += EnableFire;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other == _playerCollider)
            {
                _fireOn?.Invoke();
                _fireOn -= EnableFire;
            }
        }

        private void EnableFire()
        {
            _fire.SetActive(true);
        }
    }
}