using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 9;

    private int currentCompartment = 1; // 0 for left, 1 for center, 2 for right

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentCompartment > 0)
            {
                // Move to the left compartment
                currentCompartment--;
                MoveToCompartment();
            }
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentCompartment < 2)
            {
                // Move to the right compartment
                currentCompartment++;
                MoveToCompartment();
            }
        }
    }

    void MoveToCompartment()
    {
        float targetX = currentCompartment * 1.5f - 1.5f;
        transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
    }
}
