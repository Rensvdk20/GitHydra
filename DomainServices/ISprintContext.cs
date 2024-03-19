using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    public interface ISprintContext
    {
        ISprintState GetState();
        void SetSprintState(ISprintState state);
        void SetName(string name);
        void SetStartDate(DateTime startDate);
        void SetEndDate(DateTime endDate);
    }
}
