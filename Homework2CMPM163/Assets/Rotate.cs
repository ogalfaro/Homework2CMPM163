using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 1; 
 
    void OnMouseDrag(){
        float rotX = Input.GetAxis("Mouse X")*speed*Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y")*speed*Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }
}
