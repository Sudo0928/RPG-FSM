using UnityEngine;

public class ForceReceiver : MonoBehaviour
{
    [SerializeField] private CharacterController controller;

    [SerializeField] private float drag = 0.3f;
    private float verticalVelocity;

    public Vector3 Movement => impact + Vector3.up * verticalVelocity;
    private Vector3 dampingVelocity;
    private Vector3 impact;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            verticalVelocity += Physics.gravity.y * Time.deltaTime;
        }

        impact = Vector3.SmoothDamp(impact, Vector3.zero, ref dampingVelocity, drag);
    }

    public void Reset()
    {
        verticalVelocity = 0f;
        impact = Vector3.zero;
    }

    public void AddForce(Vector3 force)
    {
        impact += force;
    }

    public void Jump(float jumpForce)
    {
        verticalVelocity = jumpForce;
    }
}
