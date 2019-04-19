using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module_Contact : MonoBehaviour,IModule
{
    GameObject nextBtn;
    GameObject backBtn;
    public GameObject section;
    private void Start() 
    {
        nextBtn = GameObject.Find("Canvas/Contact_UI/BtnNext");  
        backBtn = GameObject.Find("Canvas/Contact_UI/BtnBack");
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
}
