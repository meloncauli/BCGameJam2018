﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour {
    private GameManager gameManager;
    private LotionManager lotionManager;
    public int lotionNeeded;
	// Use this for initialization
	void Start () {
        lotionManager = GameManager.instance.lotionManager;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag=="Player" )
        //&& lotionManager.lotionStash > lotionNeeded
        {
            //Do something
            //loadScene();
            print("you are out of here");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}