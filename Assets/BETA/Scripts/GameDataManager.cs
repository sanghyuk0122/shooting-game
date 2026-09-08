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

        // 플레이어에 대한 정보
        public float maxHP = 5f;
        public int upgrade = 0;
        public int maxUpgrade = 3;
        public int bomb = 0;
        public int maxbScore = 0;

        private void Awake()
        {
            instance = this;
            DontDestroyOnLoad(instance);
            LoadData();
        }

        public void SaveData()
        {
            if(PlayerPrefs.HasKey("id"))
            {
                string id = PlayerPrefs.GetString("id");
            }
            else
            {
                PlayerPrefs.SetString("id", "Sang0122");
            }
            PlayerPrefs.SetInt("Music", isMusic);
            PlayerPrefs.SetInt("Sound", isSound);
            PlayerPrefs.SetInt("Score", gameScore);
            string saveData = curld + "," + gameScore;
            PlayerPrefs.SetString("saveData", saveData);
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

            if (!PlayerPrefs.HasKey("Score"))
            {
                PlayerPrefs.SetInt("Score", gameScore);
            }
            gameScore = PlayerPrefs.GetInt("Score");
            if (!PlayerPrefs.HasKey("saveData"))
            {
                string saveData = curld + "," + gameScore;
                PlayerPrefs.SetString("saveData", saveData);
            }
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
