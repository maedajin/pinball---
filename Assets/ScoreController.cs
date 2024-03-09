using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int score = 0;  //スコア計算用変数

    //スコアを表示するテキスト
    private GameObject scoretext;

    // Start is called before the first frame update
    void Start()
    {

        //シーン中のScoreTextオブジェクトを取得
        this.scoretext = GameObject.Find("ScoreText");

        //タグごとにスコアをつける
        
    }

    // Update is called once per frame
    void Update()
    {

        //スコアを表示
       
            string b;

            b = "" + this.score;

            this.scoretext.GetComponent<Text>().text = b;
        


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }

        if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 15;
        }

        if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 15;
        }

        if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 20;
        }
    }
}
