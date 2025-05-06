using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_movPlayer : MonoBehaviour
{
    public float speed = 5.0f; // Velocidade do player

    // Update is called once per frame
    void Update() {
        // Obtém a entrada do teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula o vetor de movimento
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized;

        // Aplica a movimentação
        transform.Translate(movement * speed * Time.deltaTime);

    }
}