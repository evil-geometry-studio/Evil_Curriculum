using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Module_Studio : MonoBehaviour, IModule
{
    public TextMeshProUGUI textStudio;
    GameObject nextBtn;
    GameObject backBtn;
    [TextArea(3,10)]
    public string[] textUI;
    int indexText = 0;
    public GameObject section;

    private void Start() 
    {
        nextBtn = GameObject.Find("Canvas/WeAreEvil_UI/BtnNext");  
        backBtn = GameObject.Find("Canvas/WeAreEvil_UI/BtnBack");
        section.SetActive(false);   
    }
    public void EnableSection()
    {
        Debug.Log("Activa Seccion");
        section.SetActive(true);
    }

    public void DisableSection()
    {
        Debug.Log("Desactiva seccion");
        section.GetComponent<Animator>().SetTrigger("change");
    }

    public void BtnNextText()
    {
        indexText = (indexText+1) % textUI.Length;
        if(indexText == textUI.Length-1)
        {
            nextBtn.SetActive(false);
        }
        textStudio.text = textUI[indexText];
    }

    public void BtnBackText()
    {
        indexText = (indexText-1) % textUI.Length;
        if(indexText == 0)
        {
            backBtn.SetActive(false);
        }
        textStudio.text = textUI[indexText];    
    }
}
