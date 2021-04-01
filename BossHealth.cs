using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public SecondBossHealth health;
  
    public int maxhelth = 90;

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


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trial1")
        {
            health.maxhealth -= 25;
        }




    }
}
