using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float turnSpeed = 100f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.deltaTime);

        Vector3 turnRotation = Vector3.up * Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        Quaternion eulerRotation = Quaternion.Euler(turnRotation);
        rb.MoveRotation (eulerRotation * rb.rotation);
    }
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            GameManager.instance.GameOverScreen();
        }
    }
}
