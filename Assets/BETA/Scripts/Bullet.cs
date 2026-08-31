using UnityEngine;

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
                    return;
                }
            }
            else
            {
                if (other.CompareTag("Player"))
                {
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }
}
