using System;
using System.Collections.Generic;
using Tesco.HRAM.Data.Models;

namespace Tesco.HRAM.Data.Services
{
    public interface IAttendanceShiftRepository
    {
        IEnumerable<AttendanceShift> Get(int id);

    }
}
