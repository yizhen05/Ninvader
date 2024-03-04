using UnityEngine;
using UnityEngine.UI;

public class RocketController : MonoBehaviour
{

    public float speed = 1.0f;
    public GameObject bulletPrefab;
    public float shotInterval = 0.5f;
    float Interval;

    void Start()
    {
        Interval = shotInterval;
    }

    void Update()
    {
        // ユーザーからの入力を受け付けてロケットを移動させる.-2<x<2
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -2)
        {
            transform.Translate(-0.1f * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 2)
        {
            transform.Translate(0.1f * speed, 0, 0);
        }
        //タッチ操作
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if ((touch.position.x < Screen.width / 2) && transform.position.x > -2)
            {
                transform.Translate(-0.1f * speed, 0, 0);
            }
            else if ((touch.position.x > Screen.width / 2) && transform.position.x < 2)
            {
                transform.Translate(0.1f * speed, 0, 0);
            }
        }


        //shotInterval秒ごとに弾のインスタンスを生成する
        Interval -= Time.deltaTime;
        if (Interval < 0)
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Interval = shotInterval;
        }
    }
}
