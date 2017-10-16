using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
	private int mp = 53; //初期値53

	// 攻撃用の関数 
	public void Magic(mp)
    {
       if (mp <= 53){
       this.mp -= damage;
				Debug.Log("魔法攻撃をした。残りMPは"+damage);

  // 繰り返し文で上に当てはまらない場合
  else {
		Debug.Log("MPが足りないため魔法が使えない。");


 void Start ()
    {
	// 10回攻撃する繰り返し
      for (int i = 0; i < 10; i++)
    // 実行関数　１０回繰りかえして、メッセージあり
    Boss lastboss = new Boss();
	lastboss.Magic(5);
}

// Update is called once per frame
void Update ()
    {
		
	}
}