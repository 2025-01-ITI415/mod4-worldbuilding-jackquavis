using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public coin player; // Drag your Player GameObject here in the Inspector
    public int requiredCoins = 1;
    public Vector3 openPositionOffset = new Vector3(0, 2, 0); // Door moves up 5 units
    public float openSpeed = 2f;

    private bool isOpen = false;
    private Vector3 closedPosition;
    private Vector3 targetPosition;

    void Start()
    {
        closedPosition = transform.position;
        targetPosition = closedPosition;
    }

    void Update()
    {
        if (player.coinCount >= requiredCoins)
        {
            isOpen = true;
            targetPosition = closedPosition + openPositionOffset;
        }

        // Smoothly move the door to the target position
        if (transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, openSpeed * Time.deltaTime);
        }
    }
}
