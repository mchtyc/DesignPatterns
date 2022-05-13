using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public RedEnemy redEnemy;
    public BlueEnemy blueEnemy;
    public EnemySpawner spawner;

    int redCount, blueCount;
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            enemy = spawner.SpawnEnemy(redEnemy);
            redCount++;
            enemy.transform.Translate(redEnemy.transform.forward * redCount * 2f);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            enemy = spawner.SpawnEnemy(blueEnemy);
            blueCount++;
            enemy.transform.Translate(blueEnemy.transform.forward * blueCount * 2f);
        }
    }
}
