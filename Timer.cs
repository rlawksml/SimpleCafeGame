using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;
    public Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
        time = 30f;    
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            time = 0;
        }

        int t = Mathf.FloorToInt(time);
        TimeText.GetComponent<Text>();
        TimeText.text = "남은 시간 : " + t.ToString(); 
    }



}
