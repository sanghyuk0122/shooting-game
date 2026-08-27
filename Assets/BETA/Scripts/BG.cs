using UnityEngine;

namespace BETA7
{
    public class BG : MonoBehaviour
    {
        public float mapSpeed;
        public float mapSizeZ;

        private Vector3 startPos;

        void Start()
        {
            startPos = this.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            float newPosition = Mathf.Repeat(this.transform.position.z + Time.deltaTime * mapSpeed, mapSizeZ);
            transform.position = new Vector3(startPos.x, startPos.y, newPosition);
        }
    }
}
