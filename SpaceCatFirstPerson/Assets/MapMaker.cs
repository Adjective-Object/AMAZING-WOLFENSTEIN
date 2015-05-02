﻿using UnityEngine;
using System.Collections;

public class MapMaker : MonoBehaviour {

    public int[,] map;
    public int width;
    public int height;

    public GameObject ceiling;
    public GameObject floor;

	// Use this for initialization
	void Start () {
	    //map = new map[height,width];

        floor.transform.position = new Vector3(0, 0, 0);
        ceiling.transform.position = new Vector3(0, 1, 0);

        height = 12;
        width = 12;
        map = new int[,] {{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                          {1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1},
                          {1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1},
                          {1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1},
                          {1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1},
                          {1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1},
                          {1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1},
                          {1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1},
                          {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                          {1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1},
                          {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                          {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}};
        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                if (map[h, w] != 0)
                {
                    //spawn shit.
                    Debug.Log("h: " + h + ", w:" + w);
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(w, 0.5f, h);
                }
            }
        }
	}

    // Update is called once per frame
    void Update()
    {
	
	}
}
