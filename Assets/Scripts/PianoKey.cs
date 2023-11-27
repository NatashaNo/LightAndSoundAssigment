using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKey : MonoBehaviour
{
    public AudioClip pianoSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VRController"))
        {
            AudioSource.PlayClipAtPoint(pianoSound, transform.position);
        }
    }
}
