﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Repository;

public interface IEntityTimestamps
{
    DateTime CreatedDate { get; set; }
    DateTime? UpdateDate { get; set; }
    DateTime? DeletedDate { get; set; }
}
