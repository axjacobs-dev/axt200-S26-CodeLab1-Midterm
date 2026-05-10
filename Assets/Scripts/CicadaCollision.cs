using UnityEngine;

public class CicadaCollision : MonoBehaviour
{
     public CicadaData cicadaData;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(cicadaData.damage);
            }
        }
    }
}
