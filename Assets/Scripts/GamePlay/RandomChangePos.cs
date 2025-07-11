using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChangePos : MonoBehaviour
{
    [SerializeField] private float speedX = 0;
    [SerializeField] private float speedY = 0;
    [SerializeField] private float speedZ = 0.2f;
    [SerializeField] private bool randomMove = true;
    [SerializeField] private bool queueMove = false;
    [SerializeField] private float maxtimeToChgMove = 8f;
    [SerializeField] private float mintimeToChgMove = 2f;
    private float reloadChgMove;
    private GameController gameController;
    private int upSpeed = 1;

    private void Start()
    {
        reloadChgMove = maxtimeToChgMove;
    }

    
    private void FixedUpdate()
    {
        if (randomMove)
        {
            transform.Rotate(speedX * upSpeed, speedY * upSpeed, speedZ * upSpeed);
            reloadChgMove -= Time.deltaTime;
            if (reloadChgMove < 0)
            {
                speedZ = -speedZ;
                reloadChgMove = Random.Range(mintimeToChgMove, maxtimeToChgMove);
            }
        }

        if (!randomMove && !queueMove)
        {
            transform.Rotate(speedX * upSpeed, speedY * upSpeed, speedZ * upSpeed);
        }

        if (queueMove)
        {
            transform.Rotate(speedX * upSpeed, speedY * upSpeed, speedZ * upSpeed);
            reloadChgMove -= Time.deltaTime;
            if (reloadChgMove < 0)
            {
                speedZ = -speedZ;
                reloadChgMove = maxtimeToChgMove;
            }
        }
    }
}
