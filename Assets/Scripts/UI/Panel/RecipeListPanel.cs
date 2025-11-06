using UnityEngine;
using UnityEngine.UIElements;

namespace UI.Panel
{
    /// <summary>
    /// 真ん中のパネルを管理するクラス
    /// </summary>
    public class RecipeListPanel : MonoBehaviour
    {
        [SerializeField] VisualTreeAsset card_Temp;
        CookCard card_ctrl;
        UIDocument uiDoc;
        VisualElement root;

        VisualElement card_content;

        void Awake()
        {
            uiDoc = GetComponentInParent<UIDocument>();
            card_ctrl = GetComponent<CookCard>();
            root = uiDoc.rootVisualElement.Q("recipe-list-box");

            card_content = root.Q("card-list-scrollview").Q("unity-content-container");
            card_content.Clear();
        }

        /// <summary>
        /// カードを生成
        /// </summary>
        /// <param name="data"></param>
        public void CreateCard(CookDetailData data)
        {
            VisualElement elem = card_Temp.Instantiate();
            card_ctrl.Initialize(elem, data);
            card_content.Add(elem);
        }
    }
}