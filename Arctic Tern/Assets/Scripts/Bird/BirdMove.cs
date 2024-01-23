using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 9;
    public static bool canMove = false;
    public bool isJumping = false;
    public bool commingDown = false;
    public GameObject playerObject;



    private int currentCompartment = 1; // 0 for left, 1 for center, 2 for right

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if(canMove == true)
        {
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

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(isJumping == false)
            {
                isJumping = true;
                playerObject.GetComponent<Animator>().Play("Jumping Up");
                StartCoroutine(JumpSequnce());
            }
        }
        }

        if(isJumping == true)
        {
            if(commingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if(commingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }

    IEnumerator JumpSequnce()
    {
        yield return new WaitForSeconds(0.45f);
        commingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        commingDown = false;
        playerObject.GetComponent<Animator>().Play("Flying");
    }

    void MoveToCompartment()
    {
        float targetX = currentCompartment * 1.5f - 1.5f;
        transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
    }
}
