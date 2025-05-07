using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_movPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update() {
        // Obtém a entrada do teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Rotação
        float rotationInput = Input.GetAxis("Mouse X"); // Ou joystick
        transform.Rotate(0, rotationInput * rotationSpeed * Time.deltaTime, 0);
    }
}