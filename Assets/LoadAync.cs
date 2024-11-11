using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadAync : MonoBehaviour
{
    [SerializeField] Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadLevelAync());
    }

    private IEnumerator LoadLevelAync(){
        var progress = SceneManager.LoadSceneAsync("Yongsan", LoadSceneMode.Additive);
        while(!progress.isDone){
            Debug.Log(progress.progress);
            slider.value = progress.progress;
            yield return null;
        }
        Debug.Log("Level Loaded");
    }
}
