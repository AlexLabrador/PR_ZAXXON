using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    //Variables necesarias para la opción de suavizado
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    void Update()
    {
        //Con esta línea, nuestro objeto tendrá la misma posición que el jugador
        transform.position = playerPosition.position;
        //Con esta línea, la cámara mantiene su posición en X y Z, pero sigue al jugador en Y
        //Útil para juegos de plataformas
        transform.position = new Vector3(transform.position.x, playerPosition.position.y, transform.position.z);
        //Con este código, la cámara seguirá al jugador, pero alejado algo en el eje Z
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y+6, playerPosition.position.z - 20);
        //Con este código, conseguimos que siga al objeto pero con suavidad
        //La velocidad de suavizado, cuanto menor sea más brusco será el movimiento
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
        //Opcional: que la cámara mire al objeto (la cámara no puede ser ortográfica)
        transform.LookAt(playerPosition);
    }
}
