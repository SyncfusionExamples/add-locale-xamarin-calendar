using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public class CalendarPageBehavior : Behavior<ContentPage>
    {
        SfCalendar calendar;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            calendar = bindable.FindByName<SfCalendar>("calendar");
            calendar.Locale = new System.Globalization.CultureInfo("AR");
        }
    }
}
    
