using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Module_Team : MonoBehaviour, IModule
{
    [Header("Infor Member")]
    [TextArea(3,10)]
    public string[] textNameUI;
    [TextArea(3,10)]
    public string[] textRolStudioUI;
    [TextArea(3,10)]
    public string[] textResumeUI;
    [TextArea(3,10)]
    public string[] textContactUI;
    [TextArea(3,10)]
    public string[] textMoreSkillsUI;
    public Sprite[] mainSkills;
    int indexText = 0;

    /*  0 = Nombre
        1 = RolStudio
        2 = Resumen
        3 = Contacto
        4 = Mas Habilidades 
     */
     [Header("On UI")]
    public TextMeshProUGUI[] textMember;
    public Image mainSkillsImg;

    GameObject nextBtn;
    GameObject backBtn;
    public GameObject section;
    private void Start() 
    {
        nextBtn = GameObject.Find("Canvas/Team_UI/BtnNext");  
        backBtn = GameObject.Find("Canvas/Team_UI/BtnBack");
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
        indexText = (indexText+1) % textNameUI.Length;
        if(indexText == textNameUI.Length-1)
        {
            nextBtn.SetActive(false);
        }
        textMember[0].text = textNameUI[indexText];
        textMember[1].text = textRolStudioUI[indexText];
        textMember[2].text = textResumeUI[indexText];
        textMember[3].text = textContactUI[indexText];
        textMember[4].text = textMoreSkillsUI[indexText];
        mainSkillsImg.sprite = mainSkills[indexText];
    }

    public void BtnBackText()
    {
        indexText = (indexText-1) % textNameUI.Length;
        if(indexText == 0)
        {
            backBtn.SetActive(false);
        }
        textMember[0].text = textNameUI[indexText];
        textMember[1].text = textRolStudioUI[indexText];
        textMember[2].text = textResumeUI[indexText];
        textMember[3].text = textContactUI[indexText];
        textMember[4].text = textMoreSkillsUI[indexText];
        mainSkillsImg.sprite = mainSkills[indexText];
    }
}
