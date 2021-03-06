﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;

namespace ConsoleApplication2.Models
{
    public partial class MediaUrl
    {
        private string _profile;
        
        /// <summary>
        /// Optional. Optional profile hint to the client to differentiate
        /// multiple MediaUrl objects from each other
        /// </summary>
        public string Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }
        
        private string _url;
        
        /// <summary>
        /// Optional. Url for the media
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaUrl class.
        /// </summary>
        public MediaUrl()
        {
        }
    }
}
