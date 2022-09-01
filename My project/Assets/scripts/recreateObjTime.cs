using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recreateObjTime : MonoBehaviour
{
    public float maxTimer;
    private float timer = 0;
    public GameObject laser ;


    void Start()
    {
        GameObject NewLaser = Instantiate(laser);
        NewLaser.transform.position = transform.position + new Vector3(Random.Range(-10.0f,10.0f),20,0);
    }

    // Update is called once per frame
    void Update()
    {if (timer > maxTimer){
        GameObject NewLaser = Instantiate(laser);
        NewLaser.transform.position = transform.position + new Vector3(Random.Range(-28.0f,26.0f),25,0);
        Destroy(NewLaser,3);
        timer=0;

    }
       timer += Time.deltaTime; 
    }
}
