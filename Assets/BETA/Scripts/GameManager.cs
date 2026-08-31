using Codice.CM.Common.Tree;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.YamlDotNet.Core;
using UnityEngine;

namespace BETA7
{
    public class GameManager : MonoBehaviour
    {
        public GameObject[] Enemys;
        public Vector3 spawnValue;
        public int enemyCount;
        public float spawnWait;
        public float startWait;

        public List<GameObject> listEnemys = new List<GameObject>();

        public enum GameStatus
        {
            none,
            play,
            gameOver,
            gameClear
        }
        public GameStatus gameStatus = GameStatus.none;

        void Start()
        {
            gameStatus = GameStatus.play;
            StartCoroutine(SpawnEnemy());
        }

        IEnumerator SpawnEnemy()
        {
            yield return new WaitForSeconds(startWait);
            while (true)
            {
                for (int i=0; i < enemyCount; i++)
                {
                    GameObject enemy = Enemys[Random.Range(0, Enemys.Length)];
                    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    listEnemys.Add(Instantiate(enemy, spawnPosition, enemy.transform.rotation));
                    yield return new WaitForSeconds(spawnWait);
                }                
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
