using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrip : MonoBehaviour
{
    Transform camara;
    CharacterController control;

    public float speedCamara;
    public float speedPJ;

    float rotacionCamara = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //componente de camara
        camara = transform.GetChild(0).GetComponent<Transform>();

        //componente de control del personaje
        control = GetComponent<CharacterController>();

        //bloqueo del mouse
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Parametros del Mouse
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //rotacion de la camara
        transform.Rotate(new Vector3(0,mouseX,0) * speedCamara * Time.deltaTime);

        rotacionCamara -= mouseY * speedCamara * Time.deltaTime;
        rotacionCamara = Mathf.Clamp(rotacionCamara, -90, 90);
        camara.localRotation = Quaternion.Euler(new Vector3(rotacionCamara,0,0));

        //Movimiento del personaje
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movimiento = (transform.right * moveX + transform.forward * moveZ) * speedPJ * Time.deltaTime;

        control.Move(movimiento);
    }
}
