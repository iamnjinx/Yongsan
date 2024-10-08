using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class tutorialScene : MonoBehaviour
{
    public GameObject CanvasTitle;
    public Button SkipButton;
    public GameObject CanvasTitle2;
    public Button NextButton;
    public GameObject CanvasNarration;
    public List<CanvasGroup> narObjs;

    public GameObject border;

    public CanvasGroup leftHand;

    public AudioSource audioSource;

    private Coroutine tutCoroutine;
    private void Start() {
        tutCoroutine = StartCoroutine(tut());
    }

    private void Update()
    {
        CanvasNarration.transform.LookAt(Camera.main.transform.position);
    }

    IEnumerator tut(){
        PLAYERMOVEMENT.CAN_MOVE = false;
        SkipButton.interactable = false;
        CanvasTitle.GetComponent<CanvasGroup>().DOFade(1f, 3f);
        yield return new WaitForSeconds(3f);

        CanvasTitle.transform.GetChild(1).GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
        yield return new WaitForSeconds(1f);
        SkipButton.interactable = true;

        CanvasNarration.GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
        yield return new WaitForSeconds(0.5f);

        audioSource.Play();

        narObjs[0].DOFade(1f, 1.5f);
        yield return new WaitForSeconds(3f);
        narObjs[0].DOFade(0f, 0.25f);
        yield return new WaitForSeconds(0.25f);

        narObjs[1].DOFade(1f, 1.5f);
        yield return new WaitForSeconds(9f);
        narObjs[1].DOFade(0f, 0.25f);
        yield return new WaitForSeconds(0.25f);

        narObjs[2].DOFade(1f, 1.5f);
        yield return new WaitForSeconds(13f);
        narObjs[2].DOFade(0f, 0.25f);
        yield return new WaitForSeconds(0.25f);

        narObjs[3].DOFade(1f, 1.5f);
        yield return new WaitForSeconds(10f);
        narObjs[3].DOFade(0f, 0.25f);
        yield return new WaitForSeconds(0.5f);

        StartCoroutine(tut2());
    }

    public void Skip(){
        StopCoroutine(tutCoroutine);
        audioSource.Stop();
        StartCoroutine(tut2());
    }

    IEnumerator tut2(){
        NextButton.interactable = false;
        CanvasTitle.GetComponent<CanvasGroup>().DOFade(0f, 1f);
        CanvasNarration.GetComponent<CanvasGroup>().DOFade(0f, 0.5f);
        yield return new WaitForSeconds(1.5f);
        CanvasTitle.SetActive(false);
        CanvasTitle2.SetActive(true);
        CanvasTitle2.GetComponent<CanvasGroup>().DOFade(1f, 2f);
        yield return new WaitForSeconds(1f);
        NextButton.interactable = true;
    }

    public void EnterButton(){
        StopAllCoroutines();
        StartCoroutine(tut3());
    }

    IEnumerator tut3(){
        CanvasTitle2.GetComponent<CanvasGroup>().DOFade(0f, 1f);
        yield return new WaitForSeconds(1.5f);
        border.SetActive(false);
        PLAYERMOVEMENT.CAN_MOVE = true;
        for(float i = 0.01f; i > 0; i -= Time.deltaTime){
            RenderSettings.fogDensity = i;
            //Debug.Log(i);
            yield return new WaitForSeconds(0.01f);
        }
        RenderSettings.fogDensity = 0;
        leftHand.DOFade(1, 0.5f);
    }
}
