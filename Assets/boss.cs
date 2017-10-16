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
		}
  // 繰り返し文で上に当てはまらない場合
  else {
Debug.Log("MPが足りないため魔法が使えない。");
		}
}
public class Test : MonoBehaviour
	void start()
{ 
Boss lastboss = new Boss();	
// 10回攻撃する繰り返し ifの後は上の実行関数
	for (int i = 0; i < 10; i++){
		lastboss.Magic(5);
	}
}
// Update is called once per frame
void Update ()
    {
	}
