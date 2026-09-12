using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    public GameObject crater;
    public ParticleSystem particle;
    private Collider collider;
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(crater, collision.contacts[0].point, transform.rotation);

        particle.Stop();
        collider.enabled = false;
        Destroy(gameObject, 1f);
    }
}
