using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bldgui : MonoBehaviour
{
    Transform uiTransform;

    CanvasGroup canvasGroup;

    float targetSize;

    private void Awake() {
        uiTransform = transform.GetChild(0);
        canvasGroup = GetComponent<CanvasGroup>();
        targetSize = uiTransform.localScale.x;
    }

    private void Start() {
        changeUiSize(false);
    }

    public void changeUiSize(bool _is){
        if(_is){
            canvasGroup.DOFade(1, .5f);
        }
        else{
            canvasGroup.DOFade(0, .5f);
        }
    }
}
