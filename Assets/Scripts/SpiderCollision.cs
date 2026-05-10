using UnityEngine;

public class SpiderCollision : InsectCollision
{
    public SpiderData spiderData;
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                int escalatingDamage = spiderData.damage + ASCIILevelLoader.instance.resetCount;
                playerHealth.TakeDamage(escalatingDamage);
            }
        }
    }
}