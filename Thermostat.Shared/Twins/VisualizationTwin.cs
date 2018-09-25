﻿using Microsoft.Azure.TypeEdge.Twins;
using System;
using System.Collections.Generic;

namespace ThermostatApplication.Twins
{
    public class VisualizationTwin : TypeTwin
    {
        public string ChartName {get; set;}
        public string XAxisLabel {get; set;}
        public string YAxisLabel {get; set;}
        public bool Append { get; set; }
    }
}