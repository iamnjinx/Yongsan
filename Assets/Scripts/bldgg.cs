using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bldgg : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            transform.GetChild(0).GetComponent<bldgui>().changeUiSize(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")) {
            transform.GetChild(0).GetComponent<bldgui>().changeUiSize(false);
        }
    }
}
