using UnityEngine;

public class Ball : MonoBehaviour
{
    /// <summary>
    /// 足球是否進入球門
    /// </summary>
    public static bool complete;

    /// <summary>
    ///觸發事件開始：碰到勾選Is Trigger物件會執行一次
    /// </summary>
    /// <param name="other">碰到的物件碰撞資訊
    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "進球感應區")
        {
            complete = true;
        }
    }
}
