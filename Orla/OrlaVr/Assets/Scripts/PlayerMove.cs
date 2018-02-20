using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    CharacterController charControl;
    public float walkSpeed;

    private void Awake()
    {
        charControl = GetComponent <CharacterController>();
    }

    private void Update()
    {
        MovePayer();
    }

    void MovePayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 moverDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirFoward = transform.forward * vert * walkSpeed;

        charControl.SimpleMove(moverDirSide);
        charControl.SimpleMove(moveDirFoward);

    }
}
