using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterTheYongsanPark : MonoBehaviour
{
    public GameObject FadeObj;
    Image Fade;

    private void Awake() {
        FadeObj.SetActive(false);
        Fade = FadeObj.GetComponent<Image>();
    }

    public void GoToTutorialScene(){
        StartCoroutine(fadeAndLoad());
    }

    private IEnumerator fadeAndLoad(){
        FadeObj.SetActive(true);
        for(float i = 0; i < 1; i+=Time.deltaTime * 2){
            Fade.color = new Color(0,0,0,i);
            yield return new WaitForSeconds(.01f);
        }
        SceneManager.LoadScene("0418");
    }

}
