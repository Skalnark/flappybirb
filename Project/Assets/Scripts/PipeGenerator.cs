using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipe;
    public float time = 1.5f;
    void Start()
    {
        InvokeRepeating("CreatePipe", time, time);
    }

    private void CreatePipe()
    {
        float height = Random.Range(-1.75f, 1.5f);
        Instantiate(pipe, new Vector2(10f, height), transform.rotation);
    }

    public static void Reset()
    {
        foreach (GameObject p in GameObject.FindGameObjectsWithTag("pipe"))
            Destroy(p);
    }
}
