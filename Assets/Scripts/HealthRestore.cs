using UnityEngine;

public class HealthRestore : Powerup
{
    public override void Apply(GameObject player)
    {
        Debug.Log("Health Restored!");
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Apply(other.gameObject);
        }
    }

}

