//  Copyright 2011 U.S. Department of Defense

//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at

//      http://www.apache.org/licenses/LICENSE-2.0

//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Web;
using System.ServiceModel.Web;

namespace FederatedAPI
{

    /// <summary>
    /// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "_3DR_Federation_JSON" in code, svc and config file together. 
    /// </summary>
    public class _3DR_Federation_JSON : FederatedAPI.implementation._3DR_Federation_Impl, vwar.service.host.I3DRAPI
    {
        /// <summary>
        /// A simpler url for retrieving a model 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public Stream GetModelSimple(string pid, string format)
        {
            string address = GetRedirectAddressModel(implementation.APIType.JSON, pid, format);
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }

        /// <summary>
        /// Get the content for a model 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="format"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public Stream GetModel(string pid, string format, string options)
        {
            string address = GetRedirectAddressModelAdvanced(implementation.APIType.JSON, pid, format, options);
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }

        /// <summary>
        /// Get the screenshot for a content object 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public Stream GetScreenshot(string pid)
        {
            string address = GetRedirectAddress("Screenshot", implementation.APIType.JSON, pid);
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }

        /// <summary>
        /// Get the developer logo 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public Stream GetDeveloperLogo(string pid)
        {
            string address = GetRedirectAddress("DeveloperLogo", implementation.APIType.JSON, pid);
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }

        /// <summary>
        /// Get the developer logo 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public Stream GetSponsorLogo(string pid)
        {
            string address = GetRedirectAddress("SponsorLogo", implementation.APIType.JSON, pid);
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public vwar.service.host.Metadata GetMetadata(string pid)
        {
            string address = GetRedirectAddress("Metadata", implementation.APIType.JSON, pid);
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }

        /// <summary>
        /// Get all the reviews for the object. Uses query permissions 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<vwar.service.host.Review> GetReviews(string pid)
        {
            string address = GetRedirectAddress("Reviews", implementation.APIType.JSON, pid);
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }

        /// <summary>
        /// Get a supporting file from a content object 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public Stream GetSupportingFile(string pid, string filename)
        {
            string address = GetRedirectAddress("SupportingFile", implementation.APIType.JSON, pid) + "/" + filename;
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }

        /// <summary>
        /// Get a supporting file from a content object 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public Stream GetTextureFile(string pid, string filename)
        {
            string address = GetRedirectAddress("Textures", implementation.APIType.JSON, pid) + "/" + filename;
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
            WebOperationContext.Current.OutgoingResponse.Location = address;
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public List<vwar.service.host.SearchResult> Search2(string terms) { return Search(terms); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<vwar.service.host.Review> GetReviews2(string pid) { return GetReviews(pid); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public vwar.service.host.Metadata GetMetadata2(string pid) { return GetMetadata(pid); }
    }
}
