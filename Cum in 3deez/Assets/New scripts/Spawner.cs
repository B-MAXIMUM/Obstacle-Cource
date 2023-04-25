using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] RoadSegments;

    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomSegments();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateRandomSegments()
    {
        float ZValue = 50f;
        float segmentGap = 0;
        Vector3 spawnPos = new Vector3(0, -2, segmentGap);

        for(int i = 0; i < 5; i++)
        {
            int index = Random.Range(0, 3);
            segmentGap += ZValue;
            spawnPos = new Vector3(0, -1, segmentGap);
            Instantiate(RoadSegments[index], spawnPos, RoadSegments[index].transform.rotation);
        }
        segmentGap += ZValue;
        spawnPos = new Vector3(0, -1, segmentGap);
        Instantiate(RoadSegments[0], spawnPos, RoadSegments[0].transform.rotation);
    }
}
