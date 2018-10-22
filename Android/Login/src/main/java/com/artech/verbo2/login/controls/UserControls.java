package com.artech.verbo2.login.controls;

import com.artech.usercontrols.UcFactory;
import com.artech.usercontrols.UserControlDefinition;

public class UserControls
{
	public static void initializeUserControls()
	{
		UserControlDefinition definition;

		definition = new UserControlDefinition("SDSwitch", com.artech.controls.GxSwitch.class);
		definition.IsScrollable = false;
		UcFactory.addControl(definition);

	}
}
