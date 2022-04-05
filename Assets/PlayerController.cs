using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public CharacterController characterController;
    public Vector3 movement;
   public Camera cam;
    public Vector2 mouseInput;
    public float rotationSpeed;

    

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        movement.z = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        characterController.Move(movement);
        mouseInput.x = Input.GetAxis("Mouse X");
        mouseInput.y = Input.GetAxis("Mouse Y");
        mouseInput = new Vector2(mouseInput.x*rotationSpeed, mouseInput.y*rotationSpeed);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y+mouseInput.y, transform.rotation.eulerAngles.z);
        // cam.transform.rotation= Quaternion.Euler(cam.transform.rotation.eulerAngles.x + (-mouseInput.y), cam.transform.rotation.eulerAngles.y , cam.transform.rotation.eulerAngles.z);
        cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles + new Vector3(-mouseInput.y, 0f, 0f));

    }
}
