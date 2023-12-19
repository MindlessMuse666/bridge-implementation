using UnityEngine;

namespace Iron_Chest
{
    public class Chest : MonoBehaviour
    {
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void Open()
        {
            _animator.SetTrigger("open");
        }
    }
}