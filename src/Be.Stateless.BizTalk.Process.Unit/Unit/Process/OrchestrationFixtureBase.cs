﻿#region Copyright & License

// Copyright © 2012 - 2021 François Chabot
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

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.BizTalk.XLANGs.BTXEngine;

namespace Be.Stateless.BizTalk.Unit.Process
{
	public abstract class OrchestrationFixtureBase<T> : ProcessFixtureBase
		where T : BTXService
	{
		#region Base Class Member Overrides

		protected override IEnumerable<Type> AllDependantOrchestrationTypes => DependantOrchestrationTypes.Append(typeof(T));

		#endregion
	}
}
