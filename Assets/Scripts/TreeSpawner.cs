using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject tree;
    public float spawnRate = 1;
    private float timer = 0;
    public float xOffset = 1;



    // Start is called before the first frame update
    void Start()
    {
        spawnTree();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnTree();
            timer = 0;
        }



    }

    void spawnTree()
    {
        float leftPoint = transform.position.x - xOffset;
        float rightPoint = transform.position.x + xOffset;

        Instantiate(tree, new Vector3(Random.Range(leftPoint,rightPoint) , transform.position.y, transform.position.z), transform.rotation);
    }
}
