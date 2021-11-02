using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo1 : MonoBehaviour
{
    public Rigidbody balaPrefab;
    public Transform lanzador;
    public float velDisparo;
    private float iniciodisparar;
    public float tiempoDisparo;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > iniciodisparar)
        {
            iniciodisparar = Time.time + tiempoDisparo;
            Rigidbody balaPrefabInstanc;
            balaPrefabInstanc = Instantiate(balaPrefab, lanzador.position, Quaternion.identity) as Rigidbody;
            balaPrefabInstanc.AddForce(lanzador.forward * 100 * velDisparo);
        }
        
    }
}
