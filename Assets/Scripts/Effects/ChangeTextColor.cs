using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColor : MonoBehaviour
{
    private Text myText;

    [Range(0, 1f)]
    public float saturation = 1f;
    [Range(0, 1f)]
    public float brightness = 1f;
    [Range(0, 1f)]
    public float alpha = 1f;

    [Range(0, 3f)]
    public float speed = 0;

    [SerializeField]
    private float duration = 0;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        duration += speed;
        if (duration > 1f)
        {
            duration -= 1f;
        }
        myText.color = Color.HSVToRGB(duration, saturation, brightness);
        myText.color = new Color(myText.color.r, myText.color.g, myText.color.b, alpha);
    }
}
