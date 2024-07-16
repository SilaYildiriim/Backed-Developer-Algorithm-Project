﻿using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites;
using Backed_Developer_Algorithm_Project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.IService
{
    public interface ILocationDistanceService
    {
        bool IsLocationTravelExceedLimit(string location, List<int> scheduledEventIds, List<LocationDistance> locationDistances, List<Event> allEvents);
    }
}
