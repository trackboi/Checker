package crc64764aafc39fc698ee;


public class CC_Checker12
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_btn_ja:(Landroid/view/View;)V:__export__\n" +
			"n_btn_nein:(Landroid/view/View;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("Checker.CC_Checker12, Checker", CC_Checker12.class, __md_methods);
	}


	public CC_Checker12 ()
	{
		super ();
		if (getClass () == CC_Checker12.class)
			mono.android.TypeManager.Activate ("Checker.CC_Checker12, Checker", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void btn_ja (android.view.View p0)
	{
		n_btn_ja (p0);
	}

	private native void n_btn_ja (android.view.View p0);


	public void btn_nein (android.view.View p0)
	{
		n_btn_nein (p0);
	}

	private native void n_btn_nein (android.view.View p0);

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
