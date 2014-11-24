using System;

using Android.Content;
using Android.Widget;
using Com.Samsung.Android.Sdk.Cup;
//http://forum.xda-developers.com/gear-fit/development/samsung-gear-fit-sdk-available-t2872803/page2
namespace GearFitApp
{
  public class HelloCupDialog:ScupDialog
  {
    Context context;
   
    public HelloCupDialog(Context context):base(context){
      this.context = context;
    }
     

    protected override void OnCreate(){
      base.OnCreate ();
      BackEnabled = true;
      ScupLabel helloLabel = new ScupLabel (this);
      helloLabel.Text = "Hello Android";
      helloLabel.Alignment=  ScupLabel.AlignCenter;
      helloLabel.Width = ScupLabel.FillDialog;
      helloLabel.Height = ScupLabel.FillDialog;
      helloLabel.Show ();
      this.BackPressed += onBackPressed;
    }
      
    void onBackPressed (object sender, BackPressedEventArgs e)
    {
      this.Finish ();
    }
  }

 
}
