using System.Collections;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteor;
    public float spawnDistance;
    public float spawnDelay;

    void Start()
    {
        StartCoroutine(SpawnMeteor());
    }

    IEnumerator SpawnMeteor()
    {
        Vector3 position = Random.onUnitSphere * spawnDistance;
        Instantiate(meteor, position, Quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine (SpawnMeteor());
    }
}
