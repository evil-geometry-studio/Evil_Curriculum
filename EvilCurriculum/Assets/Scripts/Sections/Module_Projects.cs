using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Module_Projects : MonoBehaviour, IModule {

    public GameObject[] backgroundsProjects;

    [TextArea(3,10)]
    public string[] textUI;
    [TextArea(3,10)]
    public string[] textTitleUI;
    int indexText = 0;
    public TextMeshProUGUI textProject;
    public TextMeshProUGUI textTileProject;
    GameObject nextBtn;
    GameObject backBtn;
    public GameObject section;
    private void Start() 
    {
        nextBtn = GameObject.Find("Canvas/WorksInProgress_UI/BtnNext");  
        backBtn = GameObject.Find("Canvas/WorksInProgress_UI/BtnBack");
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
        backgroundsProjects[indexText].SetActive(false);
        indexText = (indexText+1) % textUI.Length;
        if(indexText == textUI.Length-1)
        {
            nextBtn.SetActive(false);
        }
        textProject.text = textUI[indexText];
        textTileProject.text = textTitleUI[indexText];
        backgroundsProjects[indexText].SetActive(true);
    }

    public void BtnBackText()
    {
        backgroundsProjects[indexText].SetActive(false);
        indexText = (indexText-1) % textUI.Length;
        if(indexText == 0)
        {
            backBtn.SetActive(false);
        }
        textProject.text = textUI[indexText];
        textTileProject.text = textTitleUI[indexText];
        backgroundsProjects[indexText].SetActive(true);
    }
}