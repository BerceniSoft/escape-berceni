using System.Collections;
using System.Collections.Generic;
using Dialog;
using DialogTrees;
using UnityEngine;

public class Level3Scene2DialogTree : AbstractDialogTree
{
    public override int OnDialogOptionPicked(int optionIndex, int dialogLineIndex)
    {
        // No option dialog in this scene
        return -1;
    }

    public override DialogLineInfo GetDialogLine(int dialogLineIndex)
    {
        switch (dialogLineIndex)
        {
            case 0:
            {
                return new DialogLineInfo("Nu poti fugi de mine tinere!", "Eminescu", null);
            }
            default:
            {
                return new DialogLineInfo("", "", null);
            }
        }
    }
}