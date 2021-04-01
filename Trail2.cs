using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail2 : MonoBehaviour
{
    public GameObject door;

    public GameObject sphere;

    public AudioSource playsound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(door);

            Destroy(sphere);

            playsound.Play();
        }
    }
}
