using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;

    float Timer = 0;
    public float TimeDiff = 0;
    void Start()
    {
        Timer = TimeDiff;
    }

    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > TimeDiff)
        {
            GameObject NewPipe = Instantiate(Pipe);
            NewPipe.transform.position = new Vector3(2.07f, Random.Range(-1.41f, 2.81f), 0);
            Timer = 0;

            Destroy(NewPipe, 10.0f);
        }
    }
}
