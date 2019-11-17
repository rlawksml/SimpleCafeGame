using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableDrop : MonoBehaviour
{
    public Text TF;
    public Text Count;
    public string tfok = "SUCCESS";
    public string tfno = "FAILED";
    public bool tfjuice;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void JuiceOK()
    {
        if (tfjuice)
        {
            TF.text = tfok;
            count++;
        }
        else
        {
            TF.text = tfno;
        }
        Count.text = count.ToString();
        tfjuice = false;
    }
    public void OnCollisionEnter(Collision target)
    {
        if (target.collider.CompareTag("Juice"))
        {
            Debug.Log("음료 선반 위에 올려 놓음");
            GetComponent<Collider>().enabled = false;
            tfjuice = true;
        }
        else
        {
            tfjuice = false;
        }
        JuiceOK();
    }
}
