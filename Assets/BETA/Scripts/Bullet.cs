using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace BETA7
{
    public class Bullet : MonoBehaviour
    {


        [UnityEngine.SerializeField]
        private Vector3 destination;
        [UnityEngine.SerializeField]
        private bool isThrow;
        public float speed = 1.0f;
        public bool isPlayer = true;

        public GameObject Item;

        public Vector3 dir;

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.position += dir.normalized * Time.deltaTime * speed;
        }

        public void SetBullet(Vector3 _destination)
        {
            destination = _destination;
            dir = destination - this.transform.position;
        }

        void OnTriggerEnter(Collider other)
        {
            if (isPlayer)
            {
                if (other.CompareTag("Enemy"))
                {
                    Instantiate(Item, this.transform.position, Item.transform.rotation);
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                    Player player = GameObject.Find("Player").GetComponent<Player>();
                    player.Score += 10;
                    GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
                    gameManager.Score.text = "Score : " + player.Score;
                    return;
                }
            }
            else
            {
                if (other.CompareTag("Player"))
                {
                    Player player = GameObject.Find("Player").GetComponent<Player>();
                    player.Hp -= 1;
                    GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
                    gameManager.Hp.text = "Hp : " + player.Hp;
                    Destroy(gameObject);
                    if (player.Hp <= 0)
                    {
                        Destroy(other.gameObject);
                    }
                }
            }
        }
    }
}
