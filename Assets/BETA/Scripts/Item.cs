using UnityEngine;



namespace BETA7
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
        public float itemSpeed = -0.25f;

        public ItemStatus itemStatus = ItemStatus.fuel;

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + Time.deltaTime * itemSpeed);
        }
    }
}
