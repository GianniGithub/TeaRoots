

using System;
using QMGC.WallDemolition.internet;
public class MainEvents : Singleton<MainEvents>
{
    public Action OnPlayerDaid;
    private void Start()
    {
        OnPlayerDaid += () => print("Player ist Tod");
    }
}