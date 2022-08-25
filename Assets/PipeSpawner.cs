using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float maxTime = 1; //The time we have to wait until a new pipe is spawned.
    private float timer = 0; //Count the time that has passed
    public GameObject pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime){
            GameObject newpipe = Instantiate(pipe);        //Create new pipe
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            //Destroy pipe after a while
            Destroy(newpipe, 15);
            
            //Reset the timer
            timer = 0;
        }

        //Start the timer
        timer += Time.deltaTime;
    }
}
