using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ObjectController : MonoBehaviour
{
    private Canvas canvas;

    [SerializeField] private CanvasGroup ObjectTag;
    [SerializeField] private CanvasGroup ObjectDescription;

    public ObjectDBEntity objectDBEntity;
    private ObjectTrigger objectTrigger;

    private void Awake() {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;
        objectTrigger = GetComponent<ObjectTrigger>();
        //objectDBEntity = transform.parent.GetComponent<ObjectData>().objectDBEntity;
    }

    private void Start() {
    }

    public void ShowObjectButton(bool is_in){
        if(is_in){
            ObjectTagChange(true);
        }
        else{
            ObjectTagChange(false);
            ObjectDiscChange(false);
        }
    }

    public void GiveData(){
        ObjectTag.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = objectDBEntity.ProjectName;

        ObjectDescription objectDescription = transform.GetChild(0).GetComponent<ObjectDescription>();
        objectDescription.nickname.text = objectDBEntity.Nickname;
        objectDescription.objectName.text = objectDBEntity.ProjectName;
        objectDescription.Description.text = objectDBEntity.Description;
    }

    public void ObjectTagClicked(){
        ObjectTagChange(false);
        ObjectDiscChange(true);
        objectTrigger.buttonHover(false);
    }

    public void ExitButtonClicked(){
        ObjectTagChange(true);
        ObjectDiscChange(false);
    }

    private void ObjectTagChange(bool _is){
        if(_is){
            ObjectTag.DOFade(1, .25f);
        }
        else{
            ObjectTag.DOFade(0, .25f);
        }
        ObjectTag.interactable = _is;
        ObjectTag.blocksRaycasts = _is;
    }

    private void ObjectDiscChange(bool _is){
        if(_is){
            ObjectDescription.DOFade(1, .25f);
        }
        else{
            ObjectDescription.DOFade(0, .25f);
        }
        ObjectDescription.interactable = _is;
        ObjectDescription.blocksRaycasts = _is;
    }


}
