using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider collision)
    {
        gameManager.gameOver();
    }
}
