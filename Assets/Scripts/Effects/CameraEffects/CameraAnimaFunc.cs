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

    //开始
    public void StartEffect()
    {
        animator.SetBool("Start",true);
        animator.SetBool("Over",false);
    }
    //停止
    public void StopEffect()
    {
        animator.SetBool("Start",false);
        animator.SetBool("Over",true);
    }
    //重置
    public void ResetEffect()
    {
        animator.SetBool("Start",false);
        animator.SetBool("Over",false);
    }

    //开始一段2s的效果
    public void Effect()
    {
        EffectWithTime(2.0f);
    }

    //开始一段time时长的效果
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
