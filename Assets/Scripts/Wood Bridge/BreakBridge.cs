using System;
using UnityEngine;

namespace Wood_Bridge
{
    public class BreakBridge : MonoBehaviour
    {
        [SerializeField] private Bridge _bridge;
        [SerializeField] private Outline _playerOutline;
        [SerializeField] private Collider _playercCollider;

        private event Action breakBridge;

        private void Awake()
        {
            breakBridge += _bridge.Break;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other == _playercCollider && _playerOutline.OutlineWidth != 2)
            {
                breakBridge?.Invoke();
                breakBridge -= _bridge.Break;
            }
        }
    }
}