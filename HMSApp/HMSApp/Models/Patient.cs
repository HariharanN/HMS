﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSApp.Models
{
    /// <summary>
    /// Entity to hold the patient information
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Middle Inital
        /// </summary>
        public string MiddleInitial { get; set; }
        
        /// <summary>
        /// Address
        /// </summary>
        public Address Address { get; set; }
    }
}