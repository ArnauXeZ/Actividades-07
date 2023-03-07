using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actividad1 : MonoBehaviour
{
    public float maxY = 5f;
    public float minY = -4f;
    public float maxX = 9f;
    public float minX = -9f;

    public float maxS = 5f;
    public float minS = 0.5f;

    public int total = 3;


    public GameObject Cubo;

    private Vector3 AltPos()
    {
        return new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
    }

    private void Start()
    {
        
        for(int i=0; i<total; i++)
        {
            GameObject Obj = Instantiate(Cubo, AltPos(), Quaternion.identity);
            Obj.transform.localScale = AltScale();
        }
    }

    private Vector3 AltScale()
    {
        return new Vector3(Random.Range(minS, maxS), Random.Range(minS, maxS), Random.Range(minS, maxS));
    }
}
