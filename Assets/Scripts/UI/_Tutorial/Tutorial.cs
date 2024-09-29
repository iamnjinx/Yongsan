using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
private int curTutorialId = 0;

    [Header("Tutorial_Text")]
    public List<GameObject> Tutorial_Texts;
    

    [Header("Buttons")]
    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject QuitButton;

    public void PressedNextButton(){
        curTutorialId += 1;
        TutorialChanged();
    }

    public void PressedPrevButton(){
        curTutorialId -= 1;
        TutorialChanged();
    }

    public void TutorialChanged(){
        for(int i = 0; i < Tutorial_Texts.Count; i++){
            if(i == curTutorialId){
                Tutorial_Texts[i].SetActive(true);
            }
            else{
                Tutorial_Texts[i].SetActive(false);
            }
        }
        ButtonOnOff();
    }

    public void ButtonOnOff(){
        if(curTutorialId == 0){
            nextButton.SetActive(true);
            prevButton.SetActive(false);
        }
        else if(curTutorialId == 1){
            nextButton.SetActive(true);
            prevButton.SetActive(true);
        }
        else{
            nextButton.SetActive(false);
            prevButton.SetActive(true);
        }
    }

    public void QuitTutorial(){
        transform.gameObject.SetActive(false);
    }
}
