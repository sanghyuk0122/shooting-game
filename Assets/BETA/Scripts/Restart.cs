using UnityEngine;
using UnityEngine.SceneManagement;

namespace BETA7
{
    public class Restart : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void restart()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
