﻿using ToRead.Library.Services;
using ToRead.Library.ViewModels;

namespace ToRead.ViewModels;

[QueryProperty(nameof(Poetry), "parameter")]
public class DetailPageViewModelProxy : DetailPageViewModel
{
    public DetailPageViewModelProxy(IFavoriteStorage favoriteStorage) : base(
        favoriteStorage)
    {
    }
}