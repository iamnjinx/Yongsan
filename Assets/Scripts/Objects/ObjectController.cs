using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectController : MonoBehaviour
{
    private Canvas canvas;

    [SerializeField] private GameObject ObjectTag;
    [SerializeField] private GameObject ObjectDescription;

    public ObjectDBEntity objectDBEntity;

    private void Awake() {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;
        //objectDBEntity = transform.parent.GetComponent<ObjectData>().objectDBEntity;
    }

    private void Start() {
        //GiveData();

        ObjectTag.SetActive(false);
        ObjectDescription.SetActive(false);
    }

    public void ShowObjectButton(bool is_in){
        ObjectTag.SetActive(is_in);
        if(!is_in) ObjectDescription.SetActive(is_in);
    }

    public void GiveData(){
        ObjectTag.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = objectDBEntity.ProjectName;

        ObjectDescription objectDescription = transform.GetChild(0).GetComponent<ObjectDescription>();
        objectDescription.nickname.text = objectDBEntity.Nickname;
        objectDescription.objectName.text = objectDBEntity.ProjectName;
        objectDescription.Description.text = objectDBEntity.Description;
    }

    public void ObjectTagClicked(){
        ObjectTag.SetActive(false);
        ObjectDescription.SetActive(true);
        GetComponent<ObjectTrigger>().buttonHover(false);
    }

    public void ExitButtonClicked(){
        ObjectTag.SetActive(true);
        ObjectDescription.SetActive(false);
    }
}
