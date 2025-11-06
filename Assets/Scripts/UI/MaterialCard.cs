using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    /// <summary>
    /// 詳細パネルに表示される材料や分量を表記するクラス
    /// </summary>
    public class MaterialCard : MonoBehaviour
    {
        Label material;
        Label amount;
        Label unit;
        Label memo;

        /// <summary>
        /// 初期化処理
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        public void Initialize(VisualElement root, Constants.MaterialData data)
        {
            material = root.Q<Label>("material-value");
            amount = root.Q<Label>("amount-value");
            unit = root.Q<Label>("unit-value");
            memo = root.Q<Label>("memo-value");

            SetMaterialData(data);
        }

        /// <summary>
        /// 材料カードを生成する
        /// </summary>
        public void SetMaterialData(Constants.MaterialData data)
        {
            material.text = data.material_Name;
            // もしDataのAmountに-1が入力されていなければ
            if (data.amount != -1)
            {
                unit.style.display = DisplayStyle.Flex;
                unit.text = data.unit;
                amount.text = data.amount.ToString();
            }
            else
            {
                amount.text = data.unit;        // 適量の表示を真ん中で行いたいため
                unit.style.display = DisplayStyle.None;
                unit.text = string.Empty;
            }

            unit.text = data.unit;
            memo.text = data.memo;
        }

    }
}