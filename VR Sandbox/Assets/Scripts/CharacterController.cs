using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float sensx;
    public float sensy;

    public Transform orientation;
    
    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") + Time.deltaTime * sensx;
        float mouseY = Input.GetAxisRaw("Mouse Y") + Time.deltaTime * sensy;

        yRotation += mouseX;

        xRotation += mouseY;
        xRoation = Mathf.Clamp(xRotation, -90f, 90f);

        //rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRoation.yRotation,0)
        orientation.rotation = Quaternion.Euler(0,yRotation,0);
        
    }
}
