﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        //test push voca
    }
}
