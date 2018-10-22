package com.artech.verbo2.login;

import com.artech.providers.EntityDataProvider;

public class AppEntityDataProvider extends EntityDataProvider
{
	public AppEntityDataProvider()
	{
		EntityDataProvider.AUTHORITY = "com.artech.verbo2.login.appentityprovider";
		EntityDataProvider.URI_MATCHER = buildUriMatcher();
	}
}
