using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public  Text CounterText;
    [SerializeField] float spawnRange = 7f;
    void Update()
    {
        
    }

    public void SpawnBall()
    { 
        Instantiate(ball,GenerateSpawnPosition(), ball.transform.rotation); 
    }
    
    public Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 49, 2);

        return randomPos;
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    /*

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;

        y = 49
        z = 2
    }

    */

}
