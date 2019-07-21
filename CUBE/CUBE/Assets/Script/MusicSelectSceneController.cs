using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelectSceneController : MonoBehaviour {

    public GameObject cube;

    private Quaternion startingRotation;
    public float speed = 3;


    // Use this for initialization
    void Start () {
        startingRotation = cube.transform.rotation;
    }

    void FixedUpdate()
    {
        if(Input.GetButton("Fire1"))
        {

            //startingRotation = Quaternion.Euler(0, cube.transform.rotation.y, 0);
            //return back to the starting rotation
            if (Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse X") < 0)
            {
                if (Mathf.Abs(cube.transform.rotation.y % 90.0f) < 1.0f)
                {
                    StopAllCoroutines();
                    StartCoroutine(Rotate(cube.transform.rotation.y + 90.0f));
                }
            }


            //go to 90 degrees with right arrow
            if (Input.GetAxis("Mouse X") < 0)
            {
                
                if (Mathf.Abs(cube.transform.rotation.y % 90.0f) < 1.0f)
                {
                    StopAllCoroutines();
                    StartCoroutine(Rotate(cube.transform.rotation.y + 90.0f));
                }
                
            }

            //go to -90 degrees with left arrow
            if (Input.GetAxis("Mouse X") > 0)
            {
                
                if (Mathf.Abs(cube.transform.rotation.y % 90.0f) < 1.0f)
                {
                    StopAllCoroutines();
                    StartCoroutine(Rotate(cube.transform.rotation.y - 90.0f));
                }
                    
            }

            
        }

    }

    IEnumerator Rotate(float rotationAmount)
    {

        Quaternion finalRotation = Quaternion.Euler(0, rotationAmount, 0) * startingRotation;

        while (cube.transform.rotation != finalRotation)
        {
            cube.transform.rotation = Quaternion.Lerp(cube.transform.rotation, finalRotation, Time.deltaTime * speed);
            yield return 0;
        }

    }

}
