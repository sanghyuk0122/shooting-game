using UnityEngine;

namespace BETA7
{
    public class Boss : MonoBehaviour
    {
        GameManager gameManager;
        public GameObject objBullet;
        public GameObject BulletPoint;
        
        public Player player;

        public float Hp;
        public float bossMissileTime;
        public float bossTempTime;

        private void Awake()
        {
            GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
            if (gameManagerObject != null)
            {
                gameManager = gameManagerObject.GetComponent<GameManager>();
            }
            if (gameObject == null)
            {
                Debug.Log("게임 매니저가 존재하지 않습니다.");
            }

            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            if (player == null)
            {
                Debug.LogError("플레이어가 존재하지 않습니다.");
            }
        }

        void Start()
        {
            
        }

        void BossFireBullet(int num)
        {
            switch (num)
            {
                case 0:
                    {
                        GameObject bullet = Instantiate(objBullet, BulletPoint.transform.position, this.transform.rotation);
                        Bullet bulletScript = bullet.GetComponent<Bullet>();
                        bullet.GetComponent<Bullet>().isPlayer = false;
                        bullet.GetComponent<Bullet>().SetBullet(player.transform.position);
                    }
                    break;
                case 1:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            GameObject bullet = Instantiate(objBullet, BulletPoint.transform.position, this.transform.rotation);
                            Bullet bulletScript = bullet.GetComponent<Bullet>();
                            bullet.GetComponent<Bullet>().isPlayer = false;
                            bullet.GetComponent<Bullet>().SetBullet(player.transform.position + Vector3.forward + new Vector3(-1 + i, 0, 0));

                        }
                    }
                    break;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (bossTempTime > bossMissileTime)
            {
                bossTempTime = 0;
                BossFireBullet(Random.Range(0, 2));
            }
            bossTempTime += Time.deltaTime;
        }
    }
}
