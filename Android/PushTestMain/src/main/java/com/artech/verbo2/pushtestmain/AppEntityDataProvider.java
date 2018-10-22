package com.artech.verbo2.pushtestmain;

import com.artech.providers.EntityDataProvider;

public class AppEntityDataProvider extends EntityDataProvider
{
	public AppEntityDataProvider()
	{
		EntityDataProvider.AUTHORITY = "com.artech.verbo2.pushtestmain.appentityprovider";
		EntityDataProvider.URI_MATCHER = buildUriMatcher();
	}
}
