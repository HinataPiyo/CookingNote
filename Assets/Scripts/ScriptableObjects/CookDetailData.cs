using UnityEngine;

[CreateAssetMenu(fileName = "CookDetailData", menuName = "CookDetailData", order = 0)]
public class CookDetailData : ScriptableObject
{
    [SerializeField] Constants.CookData cookData;
    public Constants.CookData CookData => cookData;
}