/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20180510;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainsBySourceResponseUnmarshaller
    {
        public static DescribeDomainsBySourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainsBySourceResponse describeDomainsBySourceResponse = new DescribeDomainsBySourceResponse();

			describeDomainsBySourceResponse.HttpResponse = context.HttpResponse;
			describeDomainsBySourceResponse.RequestId = context.StringValue("DescribeDomainsBySource.RequestId");
			describeDomainsBySourceResponse.Sources = context.StringValue("DescribeDomainsBySource.Sources");

			List<DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData> describeDomainsBySourceResponse_domainsList = new List<DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData>();
			for (int i = 0; i < context.Length("DescribeDomainsBySource.DomainsList.Length"); i++) {
				DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData domainsData = new DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData();
				domainsData.Source = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].Source");

				List<string> domainsData_domains = new List<string>();
				for (int j = 0; j < context.Length("DescribeDomainsBySource.DomainsList["+ i +"].Domains.Length"); j++) {
					domainsData_domains.Add(context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].Domains["+ j +"]"));
				}
				domainsData.Domains = domainsData_domains;

				List<DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData.DescribeDomainsBySource_DomainInfo> domainsData_domainInfos = new List<DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData.DescribeDomainsBySource_DomainInfo>();
				for (int j = 0; j < context.Length("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos.Length"); j++) {
					DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData.DescribeDomainsBySource_DomainInfo domainInfo = new DescribeDomainsBySourceResponse.DescribeDomainsBySource_DomainsData.DescribeDomainsBySource_DomainInfo();
					domainInfo.DomainName = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].DomainName");
					domainInfo.DomainCname = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].DomainCname");
					domainInfo.CreateTime = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].CreateTime");
					domainInfo.UpdateTime = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].UpdateTime");
					domainInfo.Status = context.StringValue("DescribeDomainsBySource.DomainsList["+ i +"].DomainInfos["+ j +"].Status");

					domainsData_domainInfos.Add(domainInfo);
				}
				domainsData.DomainInfos = domainsData_domainInfos;

				describeDomainsBySourceResponse_domainsList.Add(domainsData);
			}
			describeDomainsBySourceResponse.DomainsList = describeDomainsBySourceResponse_domainsList;
        
			return describeDomainsBySourceResponse;
        }
    }
}