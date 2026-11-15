using UnityEngine;

public class VelocityAnimator : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        animator.SetFloat("Velocity", rb.velocity.magnitude);
    }
}
