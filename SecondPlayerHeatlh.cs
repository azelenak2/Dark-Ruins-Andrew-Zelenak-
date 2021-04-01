using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondPlayerHeatlh : MonoBehaviour
{
    public Text Playerhealth;
    public GameObject player;

    // Start is called before the first frame update

    public int maxhealth = 90;




    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (maxhealth <= 0)
        {
            SceneManager.LoadScene(2);

        }
        Playerhealth.text = maxhealth.ToString();


    }
}


