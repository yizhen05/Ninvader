using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RockController : MonoBehaviour
{
    // Start is called before the first frame update
    float fall_speed;
    float rot_speed;
    void Start()
    {
        this.fall_speed = 2.0f + 0.5f * Random.value;
        this.rot_speed = 30.0f + 30.0f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fall_speed * Time.deltaTime, 0, Space.World);
        transform.Rotate(0, 0, rot_speed * Time.deltaTime);
        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
