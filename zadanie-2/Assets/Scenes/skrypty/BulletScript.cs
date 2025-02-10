using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed = 8f;

    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyAI>().TakeDamage();
            Destroy(gameObject);
        }
    }
}

