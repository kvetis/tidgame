﻿using UnityEngine;
using System.Collections;

public class ShitController : MonoBehaviour
{

    private Animator anim;
	private ShitSpawner shitSpawner;
	public Transform ShitPoint;
	public bool IsAfterShit = false;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
		shitSpawner = GameObject.Find ("ShitSpawner").GetComponent<ShitSpawner> ();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            takeShit();
            Debug.Log("Takin shit, my lord!");
        }
        
    }

    public void spawnShit()
    {
        Debug.Log("Spawn the shit right here!");
		shitSpawner.SpawnShitAtPoint (ShitPoint.position);
    }

    public void takeShit()
    {
        anim.SetTrigger("takePoo");
    }

	public void AfterShit(){
		IsAfterShit = true;
	}

}
 