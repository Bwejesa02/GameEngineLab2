using UnityEngine;

public class SpeedBoost : Powerup
{
    public override void Apply(GameObject player)
    {
        player.GetComponent<PlayerController>().moveSpeed += 2f;
        Debug.Log("Speed Boosted!");
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
