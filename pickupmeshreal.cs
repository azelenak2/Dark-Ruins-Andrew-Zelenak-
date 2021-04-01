using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupmeshreal : MonoBehaviour
{

    public Transform thedes;

    void OnMouseDown()
    {

        GetComponent<MeshCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = thedes.position;
        this.transform.parent = GameObject.Find("pickup").transform;

    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<MeshCollider>().enabled = true;

    }


}

