using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float amplitude = 1;
    public int speed = 5;
    Rigidbody2D rbd2D;

    public Transform objTarget;

    bool moveRigth = false, moveLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        objTarget = transform.GetChild(0);
        rbd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time) * amplitude;
        float z = transform.position.z;

        transform.position = new Vector3(x,y,z);
    }

    private void FixedUpdate() 
    {
        if(moveRigth)
        {
            rbd2D.velocity = new Vector2(speed, rbd2D.velocity.y);
        }
        else if(moveLeft)
        {
            rbd2D.velocity = new Vector2(-speed, rbd2D.velocity.y);
        }
        else
        {
            rbd2D.velocity = new Vector2(0, rbd2D.velocity.y);
        }    
    }

#region Buttons UI
    public void BtnMoveRigth()
    {
        moveRigth = true;
    }

    public void BtnMoveLeft()
    {
        moveLeft = true;
    }

    public void BtnRelease()
    {
        moveLeft = false;
        moveRigth = false;
    }
#endregion

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("section"))
        {
            other.GetComponent<IModule>().EnableSection();
            objTarget.transform.localPosition = new Vector3(11f, 0f,0f);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("section"))
        {
            other.GetComponent<IModule>().DisableSection();
            objTarget.transform.localPosition = new Vector3(0f, 0f,0f);
        }
    }
}
