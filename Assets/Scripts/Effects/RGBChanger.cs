using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBChanger : MonoBehaviour
{
    public float minS = 0.0f;
    public float maxS = 1.0f;

    public Color GetColorByDuration(float duration = 0.0f, float minSaturation = 0.0f, float maxSaturation = 1.0f, float alpha = 1.0f)
    {
        Color result = new Color(minSaturation, minSaturation, minSaturation, alpha);
        /*if (duration >= 0.0f && duration < 1.0f)
        {
            result.r = maxSaturation;
            result.b = minSaturation;
            result.g = duration * maxSaturation + minSaturation;
        }
        else if(duration >= 1.0f && duration < 2.0f)
        {
            result.g = maxSaturation;
            result.b = minSaturation;
            result.g = (1 - duration) * maxSaturation + minSaturation;
        }*/
        return result;
    }
}
