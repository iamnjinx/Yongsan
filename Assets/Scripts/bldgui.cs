using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bldgui : MonoBehaviour
{
    Transform uiTransform;

    CanvasGroup canvasGroup;

    [SerializeField] CanvasGroup bldgName;
    [SerializeField] CanvasGroup bldgDesc;

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

    public void ChangeType(bool _is){
        NameChanged(!_is);
        DescChanged(_is);
    }

    private void NameChanged(bool _is){
        if(_is) bldgName.DOFade(1, .5f);
        else bldgName.DOFade(0, .5f);
        bldgName.interactable = _is;
        bldgName.blocksRaycasts = _is;
    }
    private void DescChanged(bool _is){
        if(_is) bldgDesc.DOFade(1, .5f);
        else bldgDesc.DOFade(0, .5f);
        bldgDesc.interactable = _is;
        bldgDesc.blocksRaycasts = _is;
    }
}
