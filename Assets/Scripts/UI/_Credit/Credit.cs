using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    private int curCreditId = 0;

    [Header("Credit_Text")]
    public List<GameObject> Credit_Texts;

    [Header("Sequences")]
    public List<Image> Sequences;
    public Color curColor;
    public Color restColor;

    [Header("Buttons")]
    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject QuitButton;

    private void Update() {
        transform.LookAt(Camera.main.transform.position);
    }

    public void OpenCreditWindow(){
        curCreditId = 0;
        CreditChanged();
    }

    public void PressedNextButton(){
        curCreditId += 1;
        CreditChanged();
    }

    public void PressedPrevButton(){
        curCreditId -= 1;
        CreditChanged();
    }

    public void CreditChanged(){
        for(int i = 0; i < Credit_Texts.Count; i++){
            if(i == curCreditId){
                Credit_Texts[i].SetActive(true);
                Sequences[i].color = curColor;
            }
            else{
                Credit_Texts[i].SetActive(false);
                Sequences[i].color = restColor;
            }
        }
        ButtonOnOff();
    }

    public void ButtonOnOff(){
        if(curCreditId == 0){
            nextButton.SetActive(true);
            prevButton.SetActive(false);
        }
        else{
            nextButton.SetActive(false);
            prevButton.SetActive(true);
        }
    }

    public void QuitCredit(){
        transform.gameObject.SetActive(false);
    }
}
