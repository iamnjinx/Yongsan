using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class minimap_tp : MonoBehaviour
{
    public List<Transform> tp_positions;
    public Transform player;
    public Transform cameraRot;

    [SerializeField] private Image Fade;
    [SerializeField] private GameObject mapCanvas;

    private void Start() {
        Fade.gameObject.SetActive(false);
    }

    public IEnumerator teleportation(int id){
        PLAYERMOVEMENT.CAN_MOVE = false;
        mapCanvas.SetActive(false);
        Fade.gameObject.SetActive(true);
        for(float i = 0; i <= 255; i+=2f){
            Fade.color = new Color(0,0,0,Math.Clamp(i/255, 0, 1));
            yield return new WaitForSeconds(Time.deltaTime/10);
        }
        yield return new WaitForSeconds(1f);
        player.position = tp_positions[id].position;
        //cameraRot.parent.RotateAround(new Vector3(cameraRot.position.x, 0, cameraRot.position.z), Vector3.up, tp_positions[id].rotation.eulerAngles.y);
        PLAYERMOVEMENT.CAN_MOVE = true;
        yield return new WaitForSeconds(1f);
        for(float i = 255; i > 0; i-=2f){
            Fade.color = new Color(0,0,0,Math.Clamp(i/255, 0, 1));
            yield return new WaitForSeconds(Time.deltaTime/10);
        }
        Fade.gameObject.SetActive(false);
    }

    public void clicked_pin(int i){
        // 해당 위치로 텔레포트
        StartCoroutine(teleportation(i));
    }
}
