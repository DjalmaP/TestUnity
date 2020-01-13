using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var UpVector = new Vector3(0, 0, 1);
        var DownVector = new Vector3(0, 0, -1);
        var LeftVector = new Vector3(1, 0, 0);
        var Velocity = 5f;
        var Displacemente = new Vector3(0, 0, 0);

        if (Input.GetKey("up")) Displacemente += UpVector;
        if (Input.GetKey("down")) Displacemente += DownVector;
        if (Input.GetKey("left")) Displacemente -= LeftVector;
        if (Input.GetKey("right")) Displacemente += LeftVector;


        Displacemente.Normalize();

        transform.position += Displacemente * Velocity * Time.deltaTime;
    }
}
