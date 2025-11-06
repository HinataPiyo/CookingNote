using UnityEngine;

namespace Constants
{
    [System.Serializable]
    public class CookData
    {
        public Sprite image;
        public string title;
        public string[] tags;
        public string day;
        public int star;
        public MaterialData[] mat_Datas;
        public string[] process;
        public string memo;
    }

    [System.Serializable]
    public class MaterialData
    {
        public string material_Name;
        public float amount;
        public string unit;     // 単位
        public string memo;
    }
}