using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    private int countTutorial;

    private void Awake()
    {
        countTutorial = DataBase.playerShipLevel;
    }
}
