using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerController : MonoBehaviour
{
    [SerializeField] private GameObject playerShip;
    [SerializeField] private GameObject turrentPlayerShip;
    [SerializeField] private GameObject rocketPlayerShip;
    [SerializeField] private GameObject bombPlayerShip;
    public GameObject player;

    public static SpawnPlayerController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SpawnPlayer()
    {
        var mainPlayerShip = Instantiate(playerShip, new Vector3(0, 0, 0), Quaternion.identity);
        player = mainPlayerShip;
    }

    public void SpawnTurrentPlayerShip()
    {
        var newAssistPlayerShip = Instantiate(turrentPlayerShip, new Vector3(0, -10, 120), Quaternion.identity);
    }

    public void SpawnRocketPlayerShip()
    {
        var newAssistPlayerShip = Instantiate(rocketPlayerShip, new Vector3(0, -10, 120), Quaternion.identity);
    }

    public void SpawnBombPlayerShip()
    {
        var newAssistPlayerShip = Instantiate(bombPlayerShip, new Vector3(0, -10, 120), Quaternion.identity);
    }
}
