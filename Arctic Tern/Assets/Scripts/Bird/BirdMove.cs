using System.Collections;
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
    private float currentHeight = 0.155f; // 0 for default, 1 for one position up, 2 for two positions up

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove == true)
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
                if (isJumping == false && currentHeight < 2)
                {
                    // Move up
                    currentHeight++;
                    MoveVertical(1);
                }
            }

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (currentHeight > 0)
                {
                    // Move down
                    currentHeight--;
                    MoveVertical(-1);
                }
            }
        }

        if (isJumping == true)
        {
            if (commingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }

            if (commingDown == true)
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

void MoveVertical(int direction)
{
    float targetY = Mathf.Clamp(currentHeight * 2.155f, 0.155f, 4.155f); // Snap to the center of each square and clamp within the grid
    transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
}

void MoveToCompartment()
{
    float targetX = Mathf.Clamp(currentCompartment * 2f - 2f, -2.5f, 2.5f); // Ensure the bird stays within the grid
    transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
}
  
}
