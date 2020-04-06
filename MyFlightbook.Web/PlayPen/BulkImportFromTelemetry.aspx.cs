﻿using MyFlightbook;
using MyFlightbook.Telemetry;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

/******************************************************
 * 
 * Copyright (c) 2020 MyFlightbook LLC
 * Contact myflightbook-at-gmail.com for more information
 *
*******************************************************/

public partial class BulkImportFromTelemetry : MyFlightbook.Web.WizardPage.MFBWizardPage
{
    private string SessionKeyBase { get { return Page.User.Identity.Name + "bulkImport"; } }

    private string SessionKeyTZ { get { return SessionKeyBase + "TZ"; } }

    private string SessionKeyOpt { get { return SessionKeyBase + "Opt"; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        InitWizard(wzFlightsFromTelemetry);
        if (IsPostBack)
        {
            Session[SessionKeyTZ] = TimeZone.SelectedTimeZone;
            Session[SessionKeyOpt] = AutofillOptionsChooser.Options;
        }
        else
        {
            Session[SessionKeyOpt] = new AutoFillOptions(Request.Cookies);
        }
    }

    protected void afuUpload_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
    {
        if (e == null)
            throw new ArgumentNullException(nameof(e));
        if (e.State != AjaxControlToolkit.AjaxFileUploadState.Success)
            return;

        PendingFlight pf = new PendingFlight() { User = Page.User.Identity.Name };
        pf.FlightData = System.Text.Encoding.UTF8.GetString(e.GetContents());
        using (FlightData fd = new FlightData())
        {
            fd.AutoFill(pf, (AutoFillOptions) Session[SessionKeyOpt]);

            pf.FlightData = string.Empty;
            LogbookEntry leEmpty = new PendingFlight() { User = Page.User.Identity.Name, FlightData = string.Empty };
            if (!pf.IsEqualTo(leEmpty))
            {
                pf.TailNumDisplay = fd.TailNumber ?? string.Empty;
                // TODO: Save the flight data?  Perhaps de-sampled for size?
                pf.Commit();
            }
        }
    }

    protected void wzFlightsFromTelemetry_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        Response.Redirect("~/Member/ReviewPendingFlights.aspx");
    }
}