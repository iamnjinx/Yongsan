using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudNarration : MonoBehaviour
{
    private AudioSource audio;

    private float maxDist = 0;

    private void Start() {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            audio.Play();
            maxDist = Vector3.Distance(other.transform.position, transform.position);
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player")){
            controlVolume(other.transform);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            audio.Stop();
        }
    }

    private void controlVolume(Transform target){

        float volumeD = 1 - Vector3.Distance(target.position,transform.position)/maxDist;

        audio.volume = volumeD;
    }
}
