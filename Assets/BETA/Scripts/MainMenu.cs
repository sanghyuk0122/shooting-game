using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BETA7
{
    public class MainMenu : MonoBehaviour
    {
        public GameObject MenuBack;
        public GameObject Setting;
        public GameObject SettingBGSound;
        public GameObject SettingSound;
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
        public void BtnBack()
        {
            Setting.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenMenuBG", 1.5f);
        }
        public void OpenMenuBG()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Open");
        }
        public void BtnBGsound()
        {
            if (SettingBGSound.GetComponent<Text>().text == "¹è°æ ³ë·¡ ÄÑÁü") 
            {
                SettingBGSound.GetComponent<Text>().text = "¹è°æ ³ë·¡ ²¨Áü";
            }
            else
            {
                SettingBGSound.GetComponent<Text>().text = "¹è°æ ³ë·¡ ÄÑÁü";
            }
        }
        public void BtnSound()
        {
            if (SettingSound.GetComponent<Text>().text == "¼Ò¸® È¿°ú ÄÑÁü")
            {
                SettingSound.GetComponent<Text>().text = "¼Ò¸® È¿°ú ²¨Áü";
            }
            else
            {
                SettingSound.GetComponent<Text>().text = "¼Ò¸® È¿°ú ÄÑÁü";
            }
        }
        void OpenSetting()
        {
            Setting.SetActive(true);
            Setting.GetComponent<Animator>().SetTrigger("Open");

        }
    }
}
