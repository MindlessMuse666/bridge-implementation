using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;
    
    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hitInfo, _layer))
            {
                _destination = hitInfo.point;
                _navMeshAgent.SetDestination(_destination);
            }
        }
    }
}