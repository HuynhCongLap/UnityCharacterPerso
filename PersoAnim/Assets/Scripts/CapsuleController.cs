using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    public float speed = 2f; // speed move
    public float sensitivity = 20f;  // sensitivity of the mouse
    CharacterController player;

    public GameObject eyes;

    float moveFB;
    float moveLR;

    float rotX;
    float rotY;
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveFB = Input.GetAxis("Vertical") * speed; // capsule move vertical
        moveLR = Input.GetAxis("Horizontal") * speed; // capsule move horizontal

        rotX = Input.GetAxis("Mouse X") * sensitivity; // mouse (eye) move X
        rotY = Input.GetAxis("Mouse Y") * sensitivity; // mouse (eye) move Y

        Vector3 movement = new Vector3(moveLR, 0 , moveFB);
        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(-rotY, 0, 0);

        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);
    }
}
