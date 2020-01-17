
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    private Vector3 offset= new Vector3(1.6f,1.32f,-0.36f);


    void FixedUpdate()
    {

        transform.position = target.position + offset;

        
        

    }
}
