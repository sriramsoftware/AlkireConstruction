﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RAM.Services.Messaging.Project
{
    [Serializable]
    public class GetProjectsByCategoryRequest
    {
        public GetProjectsByCategoryRequest()
        { }
        public GetProjectsByCategoryRequest(int categoryid, string categoryname)
        {
            CategoryID = categoryid;
            CategoryName = categoryname;
        }
        [DataMember]
        public int CategoryID { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
    }
}