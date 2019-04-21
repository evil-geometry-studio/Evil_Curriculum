using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module_Contact : MonoBehaviour,IModule
{
    public GameObject section;
    private void Start() 
    {
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
