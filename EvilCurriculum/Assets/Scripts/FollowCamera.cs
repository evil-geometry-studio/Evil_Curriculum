using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject targetFollow;
    public Vector2 minPosition, maxPosition;
    public Vector2 offset;
    public float smootCam;

    private Vector2 vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, targetFollow.transform.position.x + offset.x, ref vel.x, smootCam);
        float posY = Mathf.SmoothDamp(transform.position.y, targetFollow.transform.position.y + offset.y, ref vel.y, smootCam);

        transform.position = new Vector3(
            Mathf.Clamp(posX, minPosition.x, maxPosition.x),
            Mathf.Clamp(posY, minPosition.y, maxPosition.y),
            transform.position.z);
    }
}
