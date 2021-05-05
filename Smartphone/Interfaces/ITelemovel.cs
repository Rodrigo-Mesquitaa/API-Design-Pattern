﻿namespace Smartphone.Interfaces
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();
        INormalPhone BuscarNormalPhone();
    }
}
