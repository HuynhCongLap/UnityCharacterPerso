using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject brick;
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                for (int z = 0; z < 2; z++)
                {
                    GameObject instBrick = Instantiate(brick, new Vector3(x, y, z), Quaternion.identity) as GameObject;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
