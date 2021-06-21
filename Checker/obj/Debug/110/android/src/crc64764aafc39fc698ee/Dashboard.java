package crc64764aafc39fc698ee;


public class Dashboard
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_btn_Checker:(Landroid/view/View;)V:__export__\n" +
			"n_coronaStats:(Landroid/view/View;)V:__export__\n" +
			"n_btn_Notruf:(Landroid/view/View;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("Checker.Dashboard, Checker", Dashboard.class, __md_methods);
	}


	public Dashboard ()
	{
		super ();
		if (getClass () == Dashboard.class)
			mono.android.TypeManager.Activate ("Checker.Dashboard, Checker", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void btn_Checker (android.view.View p0)
	{
		n_btn_Checker (p0);
	}

	private native void n_btn_Checker (android.view.View p0);


	public void coronaStats (android.view.View p0)
	{
		n_coronaStats (p0);
	}

	private native void n_coronaStats (android.view.View p0);


	public void btn_Notruf (android.view.View p0)
	{
		n_btn_Notruf (p0);
	}

	private native void n_btn_Notruf (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
