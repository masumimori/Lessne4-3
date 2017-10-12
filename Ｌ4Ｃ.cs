using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        // Use this for initialization
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する

        array[0] = 100;
        array[1] = 200;
        array[2] = 500;
        array[3] = 700;
        array[4] = 900;

        // 5処理を繰り返す 関数の初期値は5から　5からインクリメントで１個つつ減る

        for (int i = 4; i >= 5; i--) {

        }

        // 配列表示

        Debug.Log(array[i]);
    }
}

    // Update is called once per frame
    void Update () {
		
	}
