using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject coffee1pre;
    public GameObject coffee2pre;
    public GameObject coffee3pre;
    public GameObject coffee4pre;
    float span = 1.0f;
    float delta = 0;
    bool instance1;
    bool instance2;
    bool instance3;
    bool instance4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(instance1 == true)
        {
            GameObject coffee = Instantiate(coffee1pre, transform.position, transform.rotation) as GameObject;
        }
        if (instance2 == true)
        {
            GameObject coffee = Instantiate(coffee1pre, transform.position, transform.rotation) as GameObject;
        }
        if (instance3 == true)
        {
            GameObject coffee = Instantiate(coffee1pre, transform.position, transform.rotation) as GameObject;
        }
        if (instance4 == true)
        {
            GameObject coffee = Instantiate(coffee1pre, transform.position, transform.rotation) as GameObject;
        }
    }

    public void OnCollisionEnter(Collision target)
    {
        if (target.collider.CompareTag("coffee1"))
        {
            
        }
        if (target.collider.CompareTag("coffee2"))
        {
            
        }
        if (target.collider.CompareTag("coffee3"))
        {
            
        }
        if (target.collider.CompareTag("coffee4"))
        {
            
        }
    }
}
