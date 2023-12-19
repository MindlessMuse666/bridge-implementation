using System;
using UnityEngine;

namespace Potion
{
    public class OnTake : MonoBehaviour
    {
        [SerializeField] private Outline _outline;
        [SerializeField] private Collider _playerCollider;

        private event Action _onPotionTake;

        private void Awake()
        {
            _onPotionTake += OnPotionTake;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other == _playerCollider)
            {
                _onPotionTake?.Invoke();
                //_onPotionTake -= OnPotionTake;
            }
        }

        private void OnPotionTake()
        {
            _outline.OutlineWidth = 2;
            Destroy(gameObject);
        }
    }
}