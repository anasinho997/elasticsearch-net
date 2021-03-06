﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.License.PostLicense
{
	public class PostLicenseUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await PUT("/_xpack/license")
			.Fluent(c => c.PostLicense())
			.Request(c => c.PostLicense(new PostLicenseRequest()))
			.FluentAsync(c => c.PostLicenseAsync())
			.RequestAsync(c => c.PostLicenseAsync(new PostLicenseRequest()));
	}
}
