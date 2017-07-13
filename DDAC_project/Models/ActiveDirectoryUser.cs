﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDAC_project.Models
{
    public class ActiveDirectoryUser
    {
        public string ActiveDirectoryId { get; set; }

        public string FullName { get; set; }

        public string Position { get; set; }

        public string Location { get; set; }

        public string ImageUrl { get; set; }

        public byte[] ThumbnailPhoto { get; set; }

        public string ObjectId { get; set; }
    }
}