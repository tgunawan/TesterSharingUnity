using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float turnSpeed = 100f;
    private Rigidbody rb;
    public Transform planetCenter;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        Vector3 gravityUp = (rb.position - planetCenter.position).normalized;


        bool isUpsideDown = Vector3.Dot(gravityUp, Vector3.up) < 0;

        float horizontalInput = Input.GetAxis("Horizontal");
        if (isUpsideDown)
        {
            horizontalInput = -horizontalInput;
        }


        Vector3 localTurn = new Vector3(0f, horizontalInput * turnSpeed * Time.deltaTime, 0f);
        Quaternion eulerRotation = Quaternion.Euler(localTurn);
        rb.MoveRotation(eulerRotation * rb.rotation);

        // Gerakan maju
        rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.deltaTime);
    }


    //private void Update()
    //{
    //    rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.deltaTime);

    //    Vector3 turnRotation = Vector3.up * Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
    //    Quaternion eulerRotation = Quaternion.Euler(turnRotation);
    //    rb.MoveRotation (eulerRotation * rb.rotation);
    //}
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            GameManager.instance.GameOverScreen();
        }
    }
}
