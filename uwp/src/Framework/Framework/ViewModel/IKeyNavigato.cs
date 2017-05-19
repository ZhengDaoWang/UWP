﻿namespace lindexi.uwp.Framework.ViewModel
{
    /// <summary>
    ///     使用Key获得ViewModel
    /// </summary>
    public interface IKeyNavigato : INavigateable
    {
        void Navigateto(string key, object parameter);
    }
}