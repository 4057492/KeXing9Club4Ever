using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimaFunc : MonoBehaviour
{
    Animator animator;
    float effectTime = 2.0f;
    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void StartEffect()
    {
        animator.SetBool("Start",true);
        animator.SetBool("Over",false);
    }
    public void StopEffect()
    {
        animator.SetBool("Start",false);
        animator.SetBool("Over",true);
    }
    public void ResetEffect()
    {
        animator.SetBool("Start",false);
        animator.SetBool("Over",false);
    }

    public void Effect()
    {
        EffectWithTime(2.0f);
    }

    public void EffectWithTime(float time)
    {
        effectTime = time;
        StopAllCoroutines();
        StartCoroutine(CameraEffectCoroutine());
    }

    IEnumerator CameraEffectCoroutine()
    {
        StartEffect();
        yield return new WaitForSecondsRealtime (effectTime);
        StopEffect();
    }
}
