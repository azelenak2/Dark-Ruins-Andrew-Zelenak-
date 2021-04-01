using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondBossHealth : MonoBehaviour
{
    public Text BossHealth;
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
            SceneManager.LoadScene(3);

        }
        BossHealth.text = maxhealth.ToString();


    }
}
