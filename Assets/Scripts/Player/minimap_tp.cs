using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class minimap_tp : MonoBehaviour
{
    public List<Transform> tp_positions;
    public Transform player;
    public Transform cameraRot;

    [SerializeField] private CanvasGroup Fade;
    [SerializeField] private GameObject mapCanvas;

    private void Start() {
        Fade.gameObject.SetActive(false);
    }

    public IEnumerator teleportation(int id){
        PLAYERMOVEMENT.CAN_MOVE = false;
        mapCanvas.SetActive(false);
        Fade.gameObject.SetActive(true);
        Fade.DOFade(0, 0.5f);
        yield return new WaitForSeconds(0.5f);
        player.position = tp_positions[id].position;
        //cameraRot.parent.RotateAround(new Vector3(cameraRot.position.x, 0, cameraRot.position.z), Vector3.up, tp_positions[id].rotation.eulerAngles.y);
        PLAYERMOVEMENT.CAN_MOVE = true;
        yield return new WaitForSeconds(1f);
        Fade.DOFade(1, 0.5f);
        Fade.gameObject.SetActive(false);
    }

    public void clicked_pin(int i){
        // 해당 위치로 텔레포트
        StartCoroutine(teleportation(i));
    }
}
