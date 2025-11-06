using UnityEngine;

namespace UI.Panel
{
    /// <summary>
    /// 全てのパネルを管理するクラス
    /// </summary>
    public class PanelController : MonoBehaviour
    {
        [SerializeField] RecipeListPanel recipeListPanel;
        [SerializeField] RecipeDetailPanel recipeDetailPanel;

        [SerializeField] CookDetailData testData;

        void Start()
        {
            // 最初に料理のリストを表示
            recipeListPanel.CreateCard(testData);
        }

        void Update()
        {
            // イベントが起きたら詳細パネルに表示する
            if (Input.GetKeyDown(KeyCode.Space))
            {
                recipeDetailPanel.SetCookData(testData);
            }
        }

    }
}