using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectDescription : MonoBehaviour
{
    public TextMeshProUGUI objectName;
    public TextMeshProUGUI nickname;
    public TextMeshProUGUI Description;

    private PLAYERMOVEMENT pLAYERMOVEMENT;

    private void Awake() {
        pLAYERMOVEMENT = FindObjectOfType<PLAYERMOVEMENT>();
    }

    private void Update() {
        Vector3 tempVect = new Vector3(transform.position.x, pLAYERMOVEMENT.HmdTransform.position.y - 5, transform.position.z);
        transform.position = tempVect;
        // foreach(Transform t in transform){
        //     float dist = Vector3.Distance(t.position, Camera.main.transform.position);
        //     t.localScale = Vector3.one * (10-dist);
        // }
    }
}
