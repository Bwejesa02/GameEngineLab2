using UnityEngine;

public class Shield : Powerup
{
    public override void Apply(GameObject player)
    {
        Debug.Log("Shield Activated!");
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
