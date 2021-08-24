using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInitializer : MonoBehaviour
{
    public GameObject model,
                      modelSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        model.SetActive(true);
        model.transform.localScale = new Vector3(1, 1, 1);
        //model.transform.localEulerAngles = new Vector3(0, 180, 0);
        Instantiate(model, modelSpawnPoint.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
