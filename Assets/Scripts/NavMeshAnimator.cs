using UnityEngine;
using UnityEngine.AI;

public class NavMeshAnimator : MonoBehaviour
{
    NavMeshAgent navMesh;
    [SerializeField] private Animator animator;

    void Awake()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        animator.SetFloat("Velocity", navMesh.velocity.magnitude);
    }
}
