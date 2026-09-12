using UnityEngine;

public class CraterScript : MonoBehaviour
{
    public float destroyDelay = 10f;
    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }
}
