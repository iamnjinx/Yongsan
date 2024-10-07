using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    private ObjectController objectController;
    private SphereCollider sphereCollider;
    private LookAtPlayer lookAtPlayer;
    [SerializeField] private GameObject particleObj;
    [SerializeField] private AudioSource uiselect;
    private bool is_close = false;

    private void Awake() {
        objectController = GetComponent<ObjectController>();
        sphereCollider = GetComponent<SphereCollider>();
        lookAtPlayer = GetComponent<LookAtPlayer>();
        sphereCollider.enabled = false;
    }

    private void Start() {
        sphereCollider.enabled = true;
    }

    public void buttonHover(bool _is){
        if(_is){
            particleObj.SetActive(true);
            uiselect.Play();
        }
        else{
            particleObj.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            //Debug.Log(objectController);
            objectController.ShowObjectButton(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")) {
            objectController.ShowObjectButton(false);
            particleObj.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player")) {
            // 거리에 따라 ui 크기 및 거리 짧아짐.
        }
    }
}
