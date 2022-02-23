using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoFlot : MonoBehaviour
{
    public float duracion = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        duracion -= Time.deltaTime;
        if (duracion <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
