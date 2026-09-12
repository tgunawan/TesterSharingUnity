using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    public float shrinkSpeed = 1.0f;

    void Update()
    {
        transform.localScale *= 1f - shrinkSpeed * Time.deltaTime;
    }
}
