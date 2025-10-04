using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("SpawnPowerup", 1f, 3f);
    }

    void SpawnPowerup()
    {
        Vector3 pos = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
        int rand = Random.Range(0, 3);
        PowerupFactory.PowerupType type = (PowerupFactory.PowerupType)rand;
        PowerupFactory.CreatePowerup(type, pos);
    }
}
