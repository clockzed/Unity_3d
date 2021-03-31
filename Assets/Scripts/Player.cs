using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Renderer))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private LayerMask _whatCanBeClickOn;
    [SerializeField]
    private Material _runMaterial;

    private Material _defaultMaterial;
    private NavMeshAgent _agent;
    private Renderer _renderer;

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _defaultMaterial = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    
    public void Stop()
    {
        _agent.SetDestination(transform.position);
    }

    void Update()
    {
        _renderer.material = _agent.hasPath ? _runMaterial : _defaultMaterial;
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100, _whatCanBeClickOn))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
