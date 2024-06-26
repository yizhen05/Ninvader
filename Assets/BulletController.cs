using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;
    static public float speed = 20.0f;

    void Update()
    {
        // transform.Translate(0, 0.2f, 0);
        transform.Translate(0, 0.2f * speed * Time.deltaTime, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}