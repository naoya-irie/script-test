using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        int[] score = { 14, 18, 22, 26, 30 };
        for (int i = 0; i < score.Length; i++)
        { Debug.Log(score[i]); }
        for (int p = 4; p >= 0; p = p-1)
        { Debug.Log(score[p]); }
    }

    // Update is called once per frame
    void Update () {
		
	}
}


