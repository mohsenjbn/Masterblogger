﻿namespace BL.Domain.Services
{
    public interface IArticleCategoryValidator
    {
        void ThisalreadyExistTitle(string title);
    }
}