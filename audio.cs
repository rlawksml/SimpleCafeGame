using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public AudioClip Tfood;
    public AudioClip Ffood;
    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        this.aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coffee1")
        {
            this.aud.PlayOneShot(this.Tfood);
        }
        else if (other.gameObject.tag == "coffee2")
        {
            this.aud.PlayOneShot(this.Tfood);
        }
        else if (other.gameObject.tag == "coffee3")
        {
            this.aud.PlayOneShot(this.Tfood);
        }
        else
        {
            this.aud.PlayOneShot(this.Ffood);
        }
        Destroy(other.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }
}