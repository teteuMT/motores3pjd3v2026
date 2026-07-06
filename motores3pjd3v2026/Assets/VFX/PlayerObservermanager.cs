using System;

public static class PlayerObserverManager
{
    //Evento para informar quantidade de moedas
    public static Action<int> OnCoinsChanged;

    public static void NotifyCoinsChanged(int amount)
    {
        OnCoinsChanged?.Invoke(amount);
    }
}