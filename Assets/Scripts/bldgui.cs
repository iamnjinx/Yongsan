using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bldgui : MonoBehaviour
{
    Transform uiTransform;

    float targetSize;

    private void Awake() {
        uiTransform = transform.GetChild(0);
        targetSize = uiTransform.localScale.x;
    }

    private void Start() {
        changeUiSize(false);
    }

    public void changeUiSize(bool _is){
        if(_is){
            uiTransform.DOScale(new Vector3(targetSize, targetSize, targetSize), .5f);
        }
        else{
            uiTransform.DOScale(Vector3.zero, .5f);
        }
    }
}
