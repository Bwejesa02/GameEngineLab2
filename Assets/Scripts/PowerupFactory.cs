using UnityEngine;

public static class PowerupFactory
{
    public enum PowerupType { Speed, Health, Shield }

    public static GameObject CreatePowerup(PowerupType type, Vector3 position)
    {
        GameObject prefab = null;
        switch (type)
        {
            case PowerupType.Speed:
                prefab = Resources.Load<GameObject>("SpeedBoost");
                break;
            case PowerupType.Health:
                prefab = Resources.Load<GameObject>("HealthRestore");
                break;
            case PowerupType.Shield:
                prefab = Resources.Load<GameObject>("Shield");
                break;
        }
        return GameObject.Instantiate(prefab, position, Quaternion.identity);
    }
}
