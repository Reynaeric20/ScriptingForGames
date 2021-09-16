using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noon : MonoBehaviour
{
    public float rotationSpeed = 1;
    //public float rotationLength = 10;
    public float  startAngle;
    public float  endAngle;
    //Vector3 curVe1 = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Take A - SmoothDamping between two vectors
        //this.transform.eulerAngles = startAngle;

        Vector3 angle = this.transform.eulerAngles;
        angle.z = startAngle;
        this.transform.eulerAngles = angle;
    }

    // Update is called once per frame
    void Update()
    {
        //Take A - SmoothDamping between two vectors
        //this.transform.eulerAngles = vector3.SmoothDamp(this.transform.eulerAngles, endAngle, ref curVe1, rotationSpeed);

        Vector3 tempAngle = this.transform.eulerAngles;

        //Same thing
        tempAngle.z = tempAngle.z + rotationSpeed * Time.deltaTime;
        //tempAngle.z += rotationSpeed;

        this.transform.eulerAngles = tempAngle;

    }
}
