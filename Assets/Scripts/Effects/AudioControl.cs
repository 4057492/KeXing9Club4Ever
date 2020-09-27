using UnityEngine;

public class AudioControl : MonoBehaviour {
    void PlayWalkSound (AudioSource walkSound) {
        if (walkSound != null)
            walkSound.Play(0);
    }

}
