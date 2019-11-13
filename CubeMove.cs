using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMove : MonoBehaviour
{

    public Text m_text;
    public string m_string = "딸기 상자";
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
