using UnityEngine;

public class GravityScript : MonoBehaviour
{
    private Rigidbody rb;
    public bool onSurface;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (onSurface)
        {
            GravityAttractor.instance.PlaceOnSurface(rb);
        }
        else
        {
            GravityAttractor.instance.Attract(rb);
        }
    }
}
