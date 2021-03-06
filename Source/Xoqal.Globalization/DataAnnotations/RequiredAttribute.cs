#region License
// RequiredAttribute.cs
// 
// Copyright (c) 2012 Xoqal.com
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

namespace Xoqal.Globalization.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Specifies that a data field value is required.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class RequiredAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAttribute" /> class.
        /// </summary>
        public RequiredAttribute()
        {
            this.SetResources();
        }

        /// <summary>
        /// Sets the resources.
        /// </summary>
        private void SetResources()
        {
            if (ResourceManager.ResourceType != null)
            {
                this.ErrorMessageResourceType = ResourceManager.ResourceType;
                this.ErrorMessageResourceName = "DataAnnotations_RequiredAttribute_ValidationError";
            }
        }
    }
}
