using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBChanger : MonoBehaviour
{
    public static float maxDuration = 6f;
    public static Color GetColorByDuration(float duration = 0.0f, float minSaturation = 0.0f, float maxSaturation = 1.0f, float alpha = 1.0f)
    {
        /*Color result = new Color(minSaturation, minSaturation, minSaturation, alpha);
        if (duration >= 0 && duration < 1f)
        {
            result.g = Mathf.Lerp(0, 1f, duration);
            result.r = 1f;
            result.b = 0;
        }
        else if(duration >= 1f && duration < 2f)
        {
            result.a = 1 - Mathf.Lerp(0, 1f, duration - 1f);
            result.g = 1f;
            result.b = 0;
        }
        else if(duration >= 2f && duration < 3f)
        {
            result.b = Mathf.Lerp(0, 1f, duration - 2f);
            result.g = 1f;
            result.a = 0;
        }
        else if(duration >= 3f && duration < 4f)
        {
            result.g = 1 - Mathf.Lerp(0, 1f, duration - 3f);
            result.b = 1f;
            result.a = 0;
        }
        else if(duration >= 4f && duration < 5f)
        {
            result.a = Mathf.Lerp(0, 1, duration - 4f);
            result.b = 1f;
            result.g = 0;
        }
        else if(duration >= 5f && duration <= 6f)
        {
            result.b = 1 - Mathf.Lerp(0, 1f, duration - 5f);
            result.a = 1f;
            result.g = 0;
        }
        //result.r = Mathf.Lerp(minSaturation, maxSaturation, result.r);
        //result.g = Mathf.Lerp(minSaturation, maxSaturation, result.g);
        //result.b = Mathf.Lerp(minSaturation, maxSaturation, result.b);
        result.a = alpha;*/
        Color result = new Color(0, 0, 0, 0);
        
        return result;
    }
}
