﻿// Copyright 2015 ESRI
// 
// All rights reserved under the copyright laws of the United States
// and applicable international laws, treaties, and conventions.
// 
// You may freely redistribute and use this sample code, with or
// without modification, provided you include the original copyright
// notice and use restrictions.
// 
// See the use restrictions at <your ArcGIS install location>/DeveloperKit10.4/userestrictions.txt.
// 

using System;
using System.Collections.Generic;
using System.Text;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.SOESupport;

namespace NetEditFeaturesRESTSOE
{
    public class CustomLayerInfo
    {
        public string Name { get; set; }
        public string Type {get; set; }
        public int ID { get; set; }
        public IEnvelope Extent { get; set; }
        public string Description { get; set; }

        public CustomLayerInfo(IMapLayerInfo mapLayerInfo)
        {
            this.Name = mapLayerInfo.Name;
            this.Type = mapLayerInfo.Type;
            this.ID = mapLayerInfo.ID;
            this.Extent = mapLayerInfo.Extent;
            this.Description = mapLayerInfo.Description;
        }

        public JsonObject ToJsonObject()
        {
            byte[] jsonBytes = Conversion.ToJson((IGeometry)this.Extent);
            JsonObject env = new JsonObject(Encoding.UTF8.GetString(jsonBytes));

            JsonObject jo = new JsonObject();
            jo.AddString("name", Name);
            jo.AddString("type", Type);
            jo.AddLong("id", ID);
            jo.AddString("description", Description);
            jo.AddJsonObject("extent", env);

            return jo;
        }
    }
}