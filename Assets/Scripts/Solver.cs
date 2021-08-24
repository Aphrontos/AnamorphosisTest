using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solver : MonoBehaviour
{
    public GameObject modelSpawnPoint,
                      player,
                      winningPoint;

    private float accuracy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkAngle();
    }

    public void checkAngle()
    {
        
        RaycastHit[] hits;
        hits = Physics.RaycastAll(player.transform.position, transform.forward, 100.0F);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            if (hit.collider.GetComponent<CapsuleCollider>() != null)
            {
                accuracy = Vector3.Distance(modelSpawnPoint.transform.position, hit.point);
                //Debug.Log("Model spawn point is at "+ modelSpawnPoint.transform.position + "\nLooking at "+ hit.point + "\nAccuracy:" + accuracy);
            }
        }
    }
}
