using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coffee1 : MonoBehaviour
{
    public Text m_text;
    public string m_string = "아메리카노";
    public bool display;


    // Start is called before the first frame update
    void Start()
    {
        m_text.text = m_string;

    }

    // Update is called once per frame
    void Update()
    {
        FadeText();

       
    }


    public void OnCollisionEnter(Collision target)
    {
        if (target.collider.CompareTag("table"))
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        display = true;
    }

    public void OnTriggerExit(Collider other)
    {
        
        display = false;
    }



    public void FadeText()
    {
        if (display)
        {
            m_text.gameObject.SetActive(true);
        }
        else
        {
            m_text.gameObject.SetActive(false);

        }
    }
}
