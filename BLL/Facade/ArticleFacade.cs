﻿using BLL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Facade
{
    public sealed class ArticleFacade : DinaServiceBaseFacade<Article>, IArticleFacade
    {
    }
}
