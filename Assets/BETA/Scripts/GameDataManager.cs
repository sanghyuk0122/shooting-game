using UnityEngine;

namespace BETA7
{
    public class GameDataManager : MonoBehaviour
    {
        public static GameDataManager instance;
        public int isMusic = 0;
        public int isSound = 0;
        public float gameTime = 0;
        public int gameScore = 0;
        public string curld;

        private void Awake()
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }

        public void SaveData()
        {
            if(PlayerPrefs.HasKey("id"))
            {
                string id = PlayerPrefs.GetString("id");
                Debug.Log(id);
            }
            else
            {
                PlayerPrefs.SetString("id", "Sang0122");
            }
            PlayerPrefs.SetInt("Music", isMusic);
            PlayerPrefs.SetInt("Sound", isSound);
        }
        public void LoadData()
        {
            if (!PlayerPrefs.HasKey("Music"))
            {
                PlayerPrefs.SetInt("Music", 1);
            }
            if (!PlayerPrefs.HasKey("Sound"))
            {
                PlayerPrefs.SetInt("Sound", 1);
            }
            isMusic = PlayerPrefs.GetInt("Music");
            isSound = PlayerPrefs.GetInt("Sound");

            Debug.Log(isMusic);
            Debug.Log(isSound);
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            LoadData();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
