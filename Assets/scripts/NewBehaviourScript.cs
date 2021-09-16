using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempP = this.gameObject.transform.position;

        //tempP x = tempP.x + Speed;
        tempP.x += speed * Time.deltaTime;

        //float val = 0;

        //val = val + speed; 

        this.gameObject.transform.position = tempP;

    }
}
