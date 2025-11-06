using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    /// <summary>
    /// タグの表示を管理する
    /// </summary>
    public class Tag : MonoBehaviour
    {
        Label tag_Name;

        /// <summary>
        /// 初期化処理
        /// </summary>
        /// <param name="root"></param>
        public void Initialize(VisualElement root, string name)
        {
            tag_Name = root.Q<Label>("tag-value");
            SetTag(name);
        }
        
        /// <summary>
        /// タグ名を設定
        /// </summary>
        /// <param name="name"></param>
        public void SetTag(string name)
        {
            tag_Name.text = name;
        }
    }
}