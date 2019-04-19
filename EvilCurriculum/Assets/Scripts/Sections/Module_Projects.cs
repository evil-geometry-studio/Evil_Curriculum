using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module_Projects : MonoBehaviour, IModule {

    GameObject nextBtn;
    GameObject backBtn;
    public GameObject section;
    private void Start() 
    {
        nextBtn = GameObject.Find("Canvas/WorkInProgress_UI/BtnNext");  
        backBtn = GameObject.Find("Canvas/WorkInProgress_UI/BtnBack");
        section.SetActive(false);   
    }
    public void DisableSection () 
    {
        Debug.Log ("Desactiva seccion");
        section.GetComponent<Animator> ().SetTrigger ("change");
        
    }

    public void EnableSection () 
    {
        Debug.Log ("Activa Seccion");
        section.SetActive (true);
    }

    public void BtnNextText()
    {
        /*indexText = (indexText+1) % textUI.Length;
        if(indexText == textUI.Length-1)
        {
            nextBtn.SetActive(false);
        }
        textStudio.text = textUI[indexText];*/
    }

    public void BtnBackText()
    {
        /*indexText = (indexText-1) % textUI.Length;
        if(indexText == 0)
        {
            backBtn.SetActive(false);
        }
        textStudio.text = textUI[indexText];    */
    }
}