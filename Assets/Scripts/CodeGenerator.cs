using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using Random = UnityEngine.Random;

public static class CodeGenerator
{
    
    public static int[] GenerateWinCode() {
        int[] code = new int[3];
        for (int i = 0; i < 3; i++)
        {
            code[i] = UnityEngine.Random.Range(0, 9);
        }

        Debug.Log($"\n {code[0]} {code[1]} {code[2]} ");

        return code;
    }

    public static void GenerateStartCode(GameManager gm)
    {
        GameScreen game = gm.Menu.GamePanel.GetComponentInChildren<GameScreen>();
        // Вносим случайные измнения в код. Количество исзменений равно уровню сложности игры
        int changes = GameSettings.CurrentDifficultyLevel;
        
        // Для каждого измения выбираем случайный инструмент
        for (int i = 0; i < changes; i++) {
            Tools instrument = (Tools)Random.Range(0, 3);

            var com = new ChangeCodeCommand(gm, instrument, game, true);
            com.Execute();
        }

        Array.Copy(gm.GetCurrentCode(), gm.StartCode, 3);
    }
}
