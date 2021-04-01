using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newpickup : MonoBehaviour
{
    float throwforce = 600f;
    Vector3 objectpos;
    float distance;

    public AudioSource playsound;

    public AudioSource thrown;


    public bool didpickup = false;
    public GameObject item;
    public GameObject Tempparent;
    public bool ispickingup = false; 

    // Update is called once per frame
    void Update()

    {
        distance = Vector3.Distance(item.transform.position, Tempparent.transform.position);
        if(distance >= 3f)
        {
            ispickingup = false;
        }
        if (ispickingup == true)
        {


            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(Tempparent.transform);

            if (Input.GetMouseButtonDown(1))
            {
                item.GetComponent<Rigidbody>().AddForce(Tempparent.transform.forward * throwforce);
                thrown.Play();
                ispickingup = false;
            }
        }

        else
        {
            objectpos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectpos;
        }
    }

void OnMouseDown()
    {
        if (distance <= 3f)
        {
            ispickingup = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;

            playsound.Play();
        }
        
    }

  


    void OnMouseUp()
    {
        ispickingup = false;
    }
}
