using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 2f;
    public float endX = -5f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= endX)
        {
            Destroy(gameObject);
        }
    }

}
