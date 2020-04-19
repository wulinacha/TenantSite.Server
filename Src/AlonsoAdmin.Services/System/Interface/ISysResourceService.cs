﻿using AlonsoAdmin.Entities;
using AlonsoAdmin.Entities.System;
using AlonsoAdmin.Services.System.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlonsoAdmin.Services.System.Interface
{
    public interface ISysResourceService : IBaseService<ResourceFilterRequest, ResourceAddRequest, ResourceEditRequest>
    {

        // 特殊接口 在此定义
    }
}