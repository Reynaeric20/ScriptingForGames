using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyColor : MonoBehaviour
{
    public Color startColor;
    public Color midcolor;
    public Color endColor;
    public float fullCycleTime = 18;
    float currentLerping = 0;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = startColor;

    // Update is called once per frame
    void Update()
    {
        if (currentLerping >= 0 && currentLerping < 1)
        {
            camera.main.backgroundColor = color.Lerp(startColor, midcolor, currentLerping);
        }
        else if (currentLerping >= 1 && currentLerping < 2)
        {

        }
        else if (currentLerping >= 2 && currentLerping < 3)
        {

        }
        else
        {

        }

    }
}
