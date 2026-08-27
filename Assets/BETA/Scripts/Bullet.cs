using UnityEngine;

namespace BETA7
{
    public class Bullet : MonoBehaviour
    {
        [UnityEngine.SerializeField]
        private Vector3 destination;
        [UnityEngine.SerializeField]
        private bool isThrow = false;
        public float speed = 1.0f;
        public Vector3 dir;
<<<<<<< HEAD
        public bool isPlayer = true;
=======
        public  bool isPlayer = true;
>>>>>>> fb19c6133933e8cf1008067af713358ba6e6ebc4

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
                    Destroy(other.gameObject);
<<<<<<< HEAD
                    Destroy(gameObject);

                    Instantiate.
=======
                    Destroy(this.gameObject);
                    return;
>>>>>>> fb19c6133933e8cf1008067af713358ba6e6ebc4
                }
            }
            else
            {
                if (other.CompareTag("Player"))
                {
                    Destroy(other.gameObject);
<<<<<<< HEAD
                    Destroy(gameObject);
                }
            }

=======
                    Destroy(this.gameObject);
                }
            }
            if (other.CompareTag("Player"))
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
                return;
            }
            if (other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
>>>>>>> fb19c6133933e8cf1008067af713358ba6e6ebc4
        }
    }
}
