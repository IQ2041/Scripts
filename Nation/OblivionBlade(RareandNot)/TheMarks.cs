/*
name: null
description: null
tags: null
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/Nation/CoreNation.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/Nation/OblivionBlade(RareandNot)/CoreOblivionBladeofNulgath.cs
using Skua.Core.Interfaces;

public class TheMarks
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new();
    public CoreOblivionBladeofNulgath COBoN = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        COBoN.TheMarks();

        Core.SetOptions(false);
    }
}
