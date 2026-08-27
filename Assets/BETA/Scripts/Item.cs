<<<<<<< HEAD
using NUnit.Framework.Constraints;
using UnityEngine;

namespace BETA7
=======
using UnityEngine;

namespace BETA7

>>>>>>> fb19c6133933e8cf1008067af713358ba6e6ebc4
{
    public enum ItemStatus
    {
        fuel,
        hp,
        upgrade,
        bomb
    }
    public class Item : MonoBehaviour
    {
<<<<<<< HEAD
        public float itemSpeed = -2.5f;
        public ItemStatus itemStatus = ItemStatus.fuel;
        void Update()
        {
            this.transform.position = new Vector3(
                this.transform.position.x, this.transform.y,
                this.transform.potsition.z + Time.deltaTime * itemSpeed);
=======
        public float itemSpeed = 0.25f;
        public ItemStatus itemStatus = ItemStatus.fuel;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.position = new Vector3(
                this.transform.position.x, this.transform.position.y, this.transform.position.z + Time.deltaTime * itemSpeed);
>>>>>>> fb19c6133933e8cf1008067af713358ba6e6ebc4
        }
    }
}
