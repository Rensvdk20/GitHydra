﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    public interface ISprintState
    {
        void StartSprint();
        void CancelSprint();
        void FinishSprint();
    }
}
