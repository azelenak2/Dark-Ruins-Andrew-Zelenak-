using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trial1 : MonoBehaviour
{
    public GameObject door;

    public GameObject sphere;

    public AudioSource unlock;
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trial1")
        {
            Destroy(door);

            Destroy(sphere);

            unlock.Play();

        }
    }
}
