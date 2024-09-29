using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class PLAYERMOVEMENT : MonoBehaviour
{
    static public bool CAN_MOVE = true;

    public Transform HmdTransform;

    public ActionBasedContinuousMoveProvider moveProvider;
    public float MoveSpeed;

    private void Awake() {
    }
    private void Start() {
        MoveSpeed = moveProvider.moveSpeed;
    }

    private void Update() {

        if(!CAN_MOVE){
            objoff(false);

        }
        else{
            objoff(true);
        }
    }

    private void objoff(bool _is){
        if(_is){
            moveProvider.moveSpeed = MoveSpeed;
        }
        else{
            moveProvider.moveSpeed = 0;
        }
    }
}
