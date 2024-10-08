using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerMenuButton : MonoBehaviour
{
    [Header("Map")]
    public InputActionReference MapInputActionReference;
    [SerializeField] GameObject minimap;
    private float _menuValue;
    private bool is_menued = false;

    [Header("Credit")]
    public InputActionReference CreditInputActionReference;
    [SerializeField] GameObject credit;
    private float _creditValue;
    private bool is_credit = false;

    [Header("Narration")]
    public InputActionReference NarrationInputActionReference;
    [SerializeField] GameObject narration;
    private float _NarValue;
    private bool is_Nar = false;


    private void Start() {
        if(minimap != null) minimap.SetActive(false);
        if(credit != null) credit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!PLAYERMOVEMENT.CAN_MOVE) return;
        
        if(minimap != null){
            OpenMap();
            //OpenCredit();
        }
        if(credit != null){
            OpenCredit();
            //OpenMap();
        }
        if(narration != null){
            OpenNar();
        }
    }

    private void OpenMap(){
        _menuValue = MapInputActionReference.action.ReadValue<float>();
        if(_menuValue > 0 && !is_menued){
            if(minimap.activeSelf) minimap.SetActive(false);
            else{
                minimap.SetActive(true);
                credit.SetActive(false);
            }

            is_menued = true;
        }
        else if(_menuValue <= 0 && is_menued){
            is_menued = false;
        }
    }

    private void OpenCredit(){
        _creditValue = CreditInputActionReference.action.ReadValue<float>();
        if(_creditValue > 0 && !is_credit){
            if(credit.activeSelf) credit.SetActive(false);
            else{
                minimap.SetActive(false);
                credit.SetActive(true);
            }

            is_credit = true;
        }
        else if(_creditValue <= 0 && is_credit){
            is_credit = false;
        }
    }

    private void OpenNar(){
        _NarValue = NarrationInputActionReference.action.ReadValue<float>();
        if(_NarValue > 0 && !is_Nar){
            if(narration.activeSelf) narration.SetActive(false);
            else{
                narration.SetActive(true);
            }

            is_Nar = true;
        }
        else if(_NarValue <= 0 && is_Nar){
            is_Nar = false;
        }
    }
}
