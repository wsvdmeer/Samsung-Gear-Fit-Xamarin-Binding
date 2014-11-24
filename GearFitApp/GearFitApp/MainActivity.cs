using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Samsung.Android.Sdk.Cup;

namespace GearFitApp
{
  [Activity (Label = "GearFitApp", MainLauncher = true, Icon = "@drawable/icon")]
  public class MainActivity : Activity
  {
   
    private HelloCupDialog mHelloCupDialog = null;



    protected override void OnCreate (Bundle bundle) 
    {
      base.OnCreate (bundle);

     
      // Set our view from the "main" layout resource
      SetContentView (Resource.Layout.Main);
     
      Scup scup = new Scup();
      try {
        Console.WriteLine ("init scup");
        scup.Initialize(BaseContext);

      }catch (Exception e){
        Console.WriteLine ("no scup : " + e.Message);
      }

      var title = FindViewById<TextView> (Resource.Id.title);
      title.Click += onClick;

      //mHelloCupDialog = new HelloCupDialog(this);
    }

    void onClick (object sender, EventArgs e)
    {
      Console.WriteLine ("click");
      mHelloCupDialog = new HelloCupDialog(this);
    }

  }
}


