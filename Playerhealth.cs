using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playerhealth : MonoBehaviour
{
    public SecondPlayerHeatlh health;

    public int maxhelth = 90;

    public GameObject Projectile;

    public AudioSource hit;
    public float timer = 21;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (maxhelth <= 0)
        {
            SceneManager.LoadScene(2);
        }

        
    }


     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")

        {
            health.maxhealth -= 15;

            hit.Play();


        }
    }
}

