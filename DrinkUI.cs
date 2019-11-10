using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drink2UI : MonoBehaviour
{
    public string MyString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    void Start()
    {
        myText = GameObject.Find("StrawBerryText").GetComponent<Text>();
        myText.color = Color.clear;
    }

    void Update()
    {
        FadeText();
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        displayInfo = true;
    }

    public void OnTriggerExit(Collider other)
    {
        displayInfo = false;
    }

    void FadeText()
    {
        if(displayInfo)
        {
            myText.text = MyString;
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
