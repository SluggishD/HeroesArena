using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateUnits",5,20);
    }

    private void CreateUnits()
    {
        GameController.Instance.CreateUnit(Random.Range(1,8),transform.position,false);
    }
}
