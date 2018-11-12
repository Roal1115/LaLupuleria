package com.artech.verbo2.pushtestmain;

import com.artech.android.ContextImpl;
import com.artech.application.MyApplication;
import com.artech.base.metadata.GenexusApplication;
import com.artech.base.services.AndroidContext;
import com.artech.base.services.IGxProcedure;
import com.artech.base.services.Services;
import com.artech.providers.EntityDataProvider;
import com.artech.controls.ads.Ads;
import com.artech.verbo2.pushtestmain.controls.*;
import com.genexus.Application;
import com.genexus.ClientContext;

public class MainApplication extends MyApplication
{
	@Override
	public final void onCreate()
	{
		GenexusApplication application = new GenexusApplication();
		application.setName("verbo2");
		application.setAPIUri("http://10.0.2.2/Verbo2.NetEnvironment/");
		application.setAppEntry("PushTestMain");
		application.setMajorVersion(1);
		application.setMinorVersion(0);

		// Extensibility Point for Logging
 

		// Security
		application.setIsSecure(false);
		application.setEnableAnonymousUser(false);
		application.setClientId("");
		application.setLoginObject("");
		application.setNotAuthorizedObject("");
		application.setChangePasswordObject("");
		//application.setCompleteUserDataObject("");

		application.setAllowWebViewExecuteJavascripts(true);
		application.setAllowWebViewExecuteLocalFiles(true);

		application.setShareSessionToWebView(false);

		// Dynamic Url		
		application.setUseDynamicUrl(false);
		application.setDynamicUrlAppId("Verbo2");

		// Notifications
		application.setUseNotification(true);
		application.setNotificationSenderId("");
		application.setNotificationRegistrationHandler("NotificationsRegistrationHandler");

		MyApplication.setApp(application);

		registerModule(new com.genexus.coreexternalobjects.CoreExternalObjectsModule());

		registerModule(new com.genexus.notifications.OneSignalModule());


		UserControls.initializeUserControls();

		super.onCreate();

		
		AndroidContext.ApplicationContext = new ContextImpl(getApplicationContext());
    }

	@Override
	public Class<? extends com.artech.services.EntityService> getEntityServiceClass()
	{
		return AppEntityService.class;
	}

	@Override
	public EntityDataProvider getProvider()
	{
		return new AppEntityDataProvider();
	}

}
