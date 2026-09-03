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
            SetData();
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
                GameDataManager.instance.isMusic = 0;
            }
            else
            {
                SettingBGSound.GetComponent<Text>().text = "¹è°æ ³ë·¡ ÄÑÁü";
                GameDataManager.instance.isMusic = 1;
            }
            GameDataManager.instance.SaveData();
        }
        public void BtnSound()
        {
            if (SettingSound.GetComponent<Text>().text == "¼Ò¸® È¿°ú ÄÑÁü")
            {
                SettingSound.GetComponent<Text>().text = "¼Ò¸® È¿°ú ²¨Áü";
                GameDataManager.instance.isSound = 0;
            }
            else
            {
                SettingSound.GetComponent<Text>().text = "¼Ò¸® È¿°ú ÄÑÁü";
                GameDataManager.instance.isSound = 1;
            }
            GameDataManager.instance.SaveData();
        }
        public void SetData()
        {
            if(GameDataManager.instance.isMusic == 1)
            {
                SettingBGSound.GetComponent<Text>().text = "¹è°æ ³ë·¡ ÄÑÁü";
            }
            else if (GameDataManager.instance.isMusic == 0)
            {
                SettingBGSound.GetComponent<Text>().text = "¹è°æ ³ë·¡ ²¨Áü";
            }
            if(GameDataManager.instance.isSound == 1)
            {
                SettingSound.GetComponent<Text>().text = "¼Ò¸® È¿°ú ÄÑÁü";
            }
            else if (GameDataManager.instance.isSound == 0)
            {
                SettingSound.GetComponent<Text>().text = "¼Ò¸® È¿°ú ²¨Áü";
            }
        }
        void OpenSetting()
        {
            Setting.SetActive(true);
            Setting.GetComponent<Animator>().SetTrigger("Open");

        }
    }
}
