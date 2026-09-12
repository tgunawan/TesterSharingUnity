using UnityEngine;

public class GravityAttractor : MonoBehaviour
{
    public static GravityAttractor instance;
    public float gravity = 10f;
    private SphereCollider collider;

    void Start()
    {
        collider = GetComponent<SphereCollider>();
        instance = this;
    }
    
    private void RotateRB(Rigidbody rb)
    {
        Vector3 gravityUp = (rb.position - transform.position).normalized;
        rb.MoveRotation(Quaternion.FromToRotation(rb.transform.up, gravityUp) * rb.rotation);
    }
    public void PlaceOnSurface(Rigidbody rb)
    {
        rb.MovePosition((rb.position - transform.position).normalized * collider.radius);
        RotateRB(rb);
    }
    public void Attract (Rigidbody rb)
    {
        rb.AddForce((rb.position - transform.position).normalized * (-gravity));
        RotateRB(rb);
    }
}