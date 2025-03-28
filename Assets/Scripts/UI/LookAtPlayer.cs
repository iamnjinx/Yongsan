using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LookAtPlayer : MonoBehaviour
{
    private Transform playerTransform;

    public float objSize;


    private void Awake() {
        Camera camera = Camera.main;
        GetComponent<Canvas>().worldCamera = camera;
        playerTransform = GameObject.FindWithTag("Player").transform;
        //objSize = transform.parent.GetComponent<ObjSize>().size;
        objSize = 1;
    }

    private void Start(){
        //Debug.Log(objSize);
        foreach (Transform t in transform) {
            if(t.GetComponent<Image>() == null){
                continue;
            }
            RectTransform rt = t.GetComponent<RectTransform>();
            rt.anchoredPosition = new Vector2(rt.localPosition.x, rt.localPosition.y);
            rt.localPosition = new Vector3(rt.localPosition.x, rt.localPosition.y, objSize);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z);
        transform.LookAt(targetPos, Vector3.up);
    }
}
