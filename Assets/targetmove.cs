using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetmove : MonoBehaviour
{
    private float targetpos;
    private float targetpos2;
    public float speed = 2;
    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position.x + 10;
        targetpos2 = transform.position.x - 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < targetpos && done == false)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (transform.position.x >= targetpos)
            done = true;
        if (done == true)
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= targetpos2)
            done = false; 
    }
}
