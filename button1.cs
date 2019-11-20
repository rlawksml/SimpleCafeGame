using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button1 : MonoBehaviour
{
    public GameObject coffee1pre;
    public bool buttonclick;
    public Vector3 foodtarget;

    // Start is called before the first frame update
    void Start()
    {
        foodtarget = GameObject.FindGameObjectWithTag("coffee1").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonclick)
        {
            GameObject coffee = Instantiate(coffee1pre,
                new Vector3(foodtarget.x, foodtarget.y, foodtarget.z),
                Quaternion.identity, transform) as GameObject;
            buttonclick = false;
        }

    }

    public void buttonclicked()
    {
        buttonclick = true;
    }
}
//
