using UnityEngine;

namespace BETA7
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        public float bulletTime = 0.1f;
        public float reloadTime = 0f;
        Rigidbody thisRigi;
        public float speed = 2.0f;
        public GameObject objBullet;
        public Transform BulletPoint;

        void Start()
        {
            thisRigi = this.GetComponent<Rigidbody>();
        }

        private void Move()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(moveX, 0.0f, moveZ);
            thisRigi.linearVelocity = move * speed;

            Vector3 posInWorld = Camera.main.WorldToScreenPoint(this.transform.position);

            float posX = Mathf.Clamp(posInWorld.x, 0, Screen.width);
            float posZ = Mathf.Clamp(posInWorld.y, 0, Screen.height);

            Vector3 posInScreen = Camera.main.ScreenToWorldPoint(new Vector3(posX, posZ, 0));

            thisRigi.position = new Vector3(posInScreen.x, 0, posInScreen.z);
        }
        void Update()
        {
            Move();
            fireBullet();
        }
        void fireBullet()
        {
            reloadTime += Time.deltaTime;

            if(Input.GetButton("Fire1") && (bulletTime <= reloadTime))
            {
                reloadTime = 0f;
                GameObject bullet = Instantiate(objBullet, BulletPoint.position, this.transform.rotation);
                bullet.GetComponent<Bullet>().SetBullet(BulletPoint.position + Vector3.forward);
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
