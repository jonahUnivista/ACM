﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EnitityBase
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }

        public EntityStateOption EntityState { get; set; }
        public bool  IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();
        public abstract bool Validate();
    }
}
