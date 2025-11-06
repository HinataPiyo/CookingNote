using UnityEngine;
using UnityEngine.UIElements;

namespace UI.Panel
{
    /// <summary>
    /// 右側の詳細パネルを管理するクラス
    /// </summary>
    public class RecipeDetailPanel : MonoBehaviour
    {
        [SerializeField] VisualTreeAsset tag_Temp;
        [SerializeField] VisualTreeAsset materialCard_Temp;
        [SerializeField] VisualTreeAsset processCard_Temp;
        Tag tag_ctrl;
        MaterialCard materialCard;
        ProcessCard processCard;
        UIDocument uiDoc;
        VisualElement root;
        VisualElement detail_content;

        VisualElement icon;
        Label title;
        VisualElement tag_content;
        VisualElement material_card_content;
        VisualElement process_content;


        void Awake()
        {
            uiDoc = GetComponentInParent<UIDocument>();
            tag_ctrl = GetComponent<Tag>();
            materialCard = GetComponent<MaterialCard>();
            processCard = GetComponent<ProcessCard>();

            root = uiDoc.rootVisualElement.Q("recipe-detail-box");
            detail_content = root.Q<ScrollView>().Q("unity-content-container");

            icon = detail_content.Q("icon-box");
            title = detail_content.Q<Label>("title-value");
            tag_content = detail_content.Q("tag-content");
            material_card_content = detail_content.Q("material-card-content");
            process_content = detail_content.Q("process-content");

            // 最初は非表示
            detail_content.style.display = DisplayStyle.None;
        }

        /// <summary>
        /// 料理のデータをセットする
        /// </summary>
        /// <param name="data"></param>
        public void SetCookData(CookDetailData data)
        {
            detail_content.style.display = DisplayStyle.Flex;
            icon.style.backgroundImage = new StyleBackground(data.CookData.image);
            title.text = data.CookData.title;

            // タグを生成
            tag_content.Clear();
            foreach (string tag in data.CookData.tags)
            {
                VisualElement elem = tag_Temp.Instantiate();
                tag_ctrl.Initialize(elem, tag);
                tag_content.Add(elem);
            }

            // 材料を生成
            material_card_content.Clear();
            foreach (Constants.MaterialData material in data.CookData.mat_Datas)
            {
                VisualElement elem = materialCard_Temp.Instantiate();
                materialCard.Initialize(elem, material);
                material_card_content.Add(elem);
            }

            // 手順を生成
            process_content.Clear();
            int number = 1;     // 1番からスタート
            foreach (string process in data.CookData.process)
            {
                VisualElement elem = processCard_Temp.Instantiate();
                processCard.Initialize(elem, number, process);
                process_content.Add(elem);
                number++;
            }
        }
    }
}