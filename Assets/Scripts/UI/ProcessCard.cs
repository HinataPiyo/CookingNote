using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    /// <summary>
    /// 手順カードを管理するクラス
    /// </summary>
    public class ProcessCard : MonoBehaviour
    {
        Label number;
        Label process;

        /// <summary>
        /// 初期化処理
        /// </summary>
        /// <param name="root"></param>
        /// <param name="_number"></param>
        /// <param name="_process"></param>
        public void Initialize(VisualElement root, int _number, string _process)
        {
            number = root.Q<Label>("number-value");
            process = root.Q<Label>("process-value");

            SetProcessData(_number, _process);
        }

        /// <summary>
        /// 手順カードをセット
        /// </summary>
        /// <param name="_number"></param>
        /// <param name="_processs"></param>
        public void SetProcessData(int _number, string _processs)
        {
            number.text = _number.ToString() + ".";
            process.text = _processs;
        }
    }
}