using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // アニメーションが終了したときに呼び出されるメソッド(動作にはUnity上で別途設定が必要)
    void OnAnimationFinish()
    {
        Destroy(gameObject);
    }
}
