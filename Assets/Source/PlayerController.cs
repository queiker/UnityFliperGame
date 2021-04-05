using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private bool _isGrounded;
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _isGrounded = true;

    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(horizontal, 0.0f, vertical);
        _rigidbody.AddForce(force * Speed * Time.deltaTime, ForceMode.Force);

        if (_isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 jumpForce = Vector3.up * JumpForce;
                _rigidbody.AddForce(jumpForce, ForceMode.Impulse);
                _isGrounded = false;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

}