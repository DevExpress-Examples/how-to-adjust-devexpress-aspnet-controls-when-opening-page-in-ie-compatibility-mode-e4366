﻿using System;

public partial class PageNestedToMasterPage : System.Web.UI.Page {
    protected void Page_PreInit(object sender, EventArgs e) {
        DevExpress.Web.ASPxClasses.ASPxWebControl.SetIECompatibilityMode(7, this.Master);
    }
}