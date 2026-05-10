using UnityEngine;

public class SpiderCollision : MonoBehaviour
{
    public SpiderData spiderData;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(spiderData.damage);
            }
        }
    }
}
