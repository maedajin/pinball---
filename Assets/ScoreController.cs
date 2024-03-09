using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int score = 0;  //�X�R�A�v�Z�p�ϐ�

    //�X�R�A��\������e�L�X�g
    private GameObject scoretext;

    // Start is called before the first frame update
    void Start()
    {

        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoretext = GameObject.Find("ScoreText");

        //�^�O���ƂɃX�R�A������
        
    }

    // Update is called once per frame
    void Update()
    {

        //�X�R�A��\��
       
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
