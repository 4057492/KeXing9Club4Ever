using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;

public class AudioOverTriggerEvent : MonoBehaviour
{
    public bool ifDestroy = true;
    private AudioSource audioSource;
    public float waitTime = 0;

    [Serializable]
    public class AudioOverEvent : UnityEvent {}

    
    [FormerlySerializedAs("onAudioOver")]
    [SerializeField]
    private AudioOverEvent m_OnAudioOver = new AudioOverEvent();
    public AudioOverEvent onAudioOver
    {
        get { return m_OnAudioOver; }
        set { m_OnAudioOver = value; }
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(audioSource.clip!=null)
        {
            if(waitTime>audioSource.clip.length || waitTime == 0)
                waitTime = audioSource.clip.length;
        }
    }
    public void BeginAudioPlay()
    {
        StartCoroutine (AudioPlay());
    }

    // Update is called once per frame
    IEnumerator AudioPlay()
    {
        audioSource.Play();
        yield return new WaitForSecondsRealtime(waitTime);
        onAudioOver.Invoke();
        yield return null;
        if (ifDestroy)
        {
            Destroy(gameObject);
        }
        yield return null;
    }
}
