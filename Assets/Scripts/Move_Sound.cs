using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Move_Sound : MonoBehaviour
{
    public InputActionReference MapInputActionReference;
    public ActionBasedContinuousMoveProvider moveProvider;
    private Vector2 _walkValue;

    public AudioSource walkSound;
    // Update is called once per frame
    void Update()
    {
        if(moveProvider.moveSpeed == 0) return;
        
        _walkValue = MapInputActionReference.action.ReadValue<Vector2>();
        //Debug.Log(_walkValue);
        if(_walkValue != Vector2.zero && !walkSound.isPlaying){
            //Debug.Log("walk");
            walkSound.Play();
        }
        else if(_walkValue == Vector2.zero){
            walkSound.Stop();
        }
    }
}
