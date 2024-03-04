using UnityEngine;
using UnityEngine.UI;

public class RocketController : MonoBehaviour
{
    public InputField speedInputField;

    private float speed = 1.0f;

    void Update()
    {
        // ユーザーからの入力を受け付けてロケットを移動させる
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f * speed, 0, 0);
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0;
                transform.position = touchPosition;
            }
        }

        // テキストボックスの値に応じて速度を変更する
        if (speedInputField != null && !string.IsNullOrEmpty(speedInputField.text))
        {
            if (float.TryParse(speedInputField.text, out float newSpeed))
            {
                speed = newSpeed;
            }
        }
    }
}
