using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    [SerializeField] float speed;
    private Quaternion rotate;
    float y;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        y += Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, y, 0);
        /* rotate = transform.rotation;
         rotate.y += Time.deltaTime * speed;
         transform.rotation = rotate;*/

        //transform.RotateAround(transform.position, Vector3.back, speed * Time.deltaTime);
    }
    private void FixedUpdate()
    {

    }
}
