using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatinList;
    public int[] jellyGoldList;

    public int[] numGoldList;
    public int[] clickGoldList;


    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAc;

    public void ChageAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level-1];
    }
}
