using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Table : MonoBehaviour
{
    public GameObject coffee1pre;
    public GameObject coffee2pre;
    public GameObject coffee3pre;
    public GameObject coffee4pre;

    public Text TF;
    Text Count;
    string tfok = "주문 성공!";
    string tfno = "틀린 주문입니다.";
    bool tfjuice;
    int coffeecount = 0;
    int coffee4count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(coffeecount);
        missionend();
    }

    public void JuiceOK()
    {
        if (tfjuice)
        {
            TF.text = tfok;
        }
        else
        {
            TF.text = tfno;
        }
        Count.text = coffeecount.ToString();

    }
    public void OnCollisionEnter(Collision target)
    {
        /*
        if (target.collider.CompareTag("coffee1"))
        {
            GameObject coffee = Instantiate(coffee1pre, new Vector3(transform.position.x , transform.position.y , transform.position.z), Quaternion.identity) as GameObject;
        }
        if (target.collider.CompareTag("coffee2"))
        {
            GameObject coffee2 = Instantiate(coffee1pre, transform.position, Quaternion.identity) as GameObject;
        }
        if (target.collider.CompareTag("coffee3"))
        {
            GameObject coffee3 = Instantiate(coffee1pre, transform.position, Quaternion.identity) as GameObject;
        }
        if (target.collider.CompareTag("coffee4"))
        {
            GameObject coffee4 = Instantiate(coffee1pre, transform.position, Quaternion.identity) as GameObject;
        }
        */

        if (target.collider.CompareTag("coffee1"))

        {
            Debug.Log("음료 선반 위에 올려 놓음");
            tfjuice = true;
            coffeecount++;
            JuiceOK();
        }
        else if (target.collider.CompareTag("coffee4"))
        {
            tfjuice = true;
            coffee4count++;
            JuiceOK();
        }
        else
        {
            tfjuice = false;
            JuiceOK();
        }



    }

    void missionend()
    {
        if(coffeecount == 2)
        {
            Debug.Log("Quit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
 

}
