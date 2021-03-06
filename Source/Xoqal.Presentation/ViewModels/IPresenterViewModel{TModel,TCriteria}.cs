#region License
// IPresenterViewModel{TModel,TCriteria}.cs
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

namespace Xoqal.Presentation.ViewModels
{
    using Xoqal.Core.Models;

    /// <summary>
    /// Represents a base view-model to show data in paginated manner.
    /// </summary>
    public interface IPresenterViewModel<TModel, TCriteria> : IPresenterViewModel, IItemCollectionViewModel<TModel>
        where TModel : class
        where TCriteria : PaginatedCriteria, new()
    {
        /// <summary>
        /// Gets or sets the criteria.
        /// </summary>
        TCriteria Criteria { get; set; }
    }
}
