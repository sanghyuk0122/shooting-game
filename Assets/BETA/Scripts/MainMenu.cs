using UnityEngine;
using UnityEngine.SceneManagement;

namespace BETA7
{
    public class MainMenu : MonoBehaviour
    {
        public GameObject MenuBack;
        public GameObject Setting;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void BtnStart()
        {
            SceneManager.LoadScene("SampleScene");
        }
        public void BtnSetting()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenSetting", 1.5f);
        }
        public void BtnExit()
        {
            Application.Quit();
        }
        void OpenSetting()
        {
            Setting.SetActive(true);
            Setting.GetComponent<Animator>().SetTrigger("Open");

        }
    }
}
