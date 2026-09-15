using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.YamlDotNet.Core;
using UnityEngine;
using UnityEngine.UI;

namespace BETA7
{
    public class GameManager : MonoBehaviour
    {
        public GameObject[] Enemys;
        public Vector3 spawnValue;
        public int enemyCount;
        public float spawnWait;
        public float startWait;

        public Text Hp;
        public Text Upgrade;
        public Text Score;
        public Text Bomb;

        public float bossTime;
        public Boss bossScript;
        public GameObject Boss;
        public bool isBoss = false;
        public float gameTime;

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

            Player player = GameObject.Find("Player").GetComponent<Player>();
            player.Hp = GameDataManager.instance.maxHP;
            player.Upgrade = GameDataManager.instance.upgrade;
            player.Bomb = GameDataManager.instance.bomb;
            player.Score = GameDataManager.instance.gameScore;

            Hp.text = "HP : " + player.Hp;
            Upgrade.text = "Upgrade : " + player.Upgrade;
            Bomb.text = "Bomb : " + player.Bomb;
            Score.text = "Score : " + player.Score;

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
        void BossInit()
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, 5);
            Instantiate(Boss, spawnPosition, Boss.transform.rotation);
        }

        // Update is called once per frame
        void Update()
        {
            if (!isBoss)
            {
                if (gameTime > bossTime)
                {
                    StopAllCoroutines();
                    Invoke("BossInit", 2.0f);
                    isBoss = true;
                }
            }
            gameTime += Time.deltaTime;
        }
    }
}
