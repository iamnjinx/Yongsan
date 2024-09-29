using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class OnEnableDoTween : MonoBehaviour
{
    private float scaleSize;

    private void Awake() {
        scaleSize = transform.localScale.x;
    }

    private void OnEnable() {
        transform.DOScale(0,0);
        transform.DOScale(scaleSize, 0.25f);
    }
}
