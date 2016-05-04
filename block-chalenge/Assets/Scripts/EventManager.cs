/*****************************************************\
*
*  Copyright (C) 2016, Douglas Knowman 
*  douglasknowman@gmail.com
*
*  Distributed under the terms of GNU GPL v3 license.
*  Always KISS.
*
\*****************************************************/

using UnityEngine;
using System.Collections;

public enum GameEventType
{
    OneLineClean,TwoLineClean,ThreeLineClean,FourLineClean, PieceMove, PieceAccent
}
public delegate void GameEvent(GameEventType type);
public static class EventManager
{
    // Public variables.
    public static GameEvent gameEvent;
    // Private variables.
    // Unity functions.
    static EventManager()
    {
        gameEvent += eventDebugger;
    }

    // EventManager functions.
    static void eventDebugger(GameEventType type)
    {
//        Debug.Log(type.ToString());
    }
}
