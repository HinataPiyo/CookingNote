using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    /// <summary>
    /// 画面真ん中に表示されるエレメントを管理
    /// </summary>
    public class CookCard : MonoBehaviour
    {
        [SerializeField] VisualTreeAsset tag_Temp;
        Tag tag_ctrl;
        VisualElement icon;
        Label title;
        VisualElement tag_content;
        Label day;
        Label star;

        void Awake()
        {
            tag_ctrl = GetComponent<Tag>();
        }


        /// <summary>
        /// 初期化処理
        /// </summary>
        /// <param name="root">Cardの親エレメント</param>
        public void Initialize(VisualElement root, CookDetailData data)
        {
            icon = root.Q("icon-box");
            title = root.Q<Label>("title-value");
            tag_content = root.Q("tag-content");
            day = root.Q<Label>("day-value");
            star = root.Q<Label>("star");

            SetCookData(data);
        }
        
        /// <summary>
        /// 料理データをセット
        /// </summary>
        /// <param name="data"></param>
        public void SetCookData(CookDetailData data)
        {
            tag_content.Clear();
            foreach(string tag in data.CookData.tags)
            {
                VisualElement elem = tag_Temp.Instantiate();
                tag_ctrl.Initialize(elem, tag);
                tag_content.Add(elem);
            }

            icon.style.backgroundImage = new StyleBackground(data.CookData.image);
            title.text = data.CookData.title;
            day.text = data.CookData.day;
        }
    }
}