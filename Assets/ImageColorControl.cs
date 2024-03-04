using UnityEngine;
using UnityEngine.UI;

public class ImageColorControl : MonoBehaviour
{
    void Start()
    {
        Color color = gameObject.GetComponent<Image>().color;
        color.r = 0.8f;
        color.g = 0.3f;
        color.b = 0.1f;
        color.a = 0.5f;
        gameObject.GetComponent<Image>().color = color;
    }
}