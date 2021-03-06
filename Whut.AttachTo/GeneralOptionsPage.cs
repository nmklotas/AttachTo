﻿using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace AttachTo
{
    public class GeneralOptionsPage : DialogPage
    {
        public GeneralOptionsPage()
        {
            ShowAttachToIIS = true;
            ShowAttachToArcSOC = true;
            ShowAttachToArcMap = true;
            ShowAttachToArcCatalog = true;
            ShowAttachToDBTool = true;
            ShowAttachToIISExpress = false;
            ShowAttachToNUnit = false;
        }

        [Category("General")]
        [DisplayName("Show 'Attach to IIS' command")]
        [Description("Show 'Attach to IIS' command in Tools menu.")]
        public bool ShowAttachToIIS { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to IIS Express command")]
        [Description("Show 'Attach to IIS Express command in Tools menu.")]
        public bool ShowAttachToIISExpress { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to NUnit' command")]
        [Description("Show 'Attach to NUnit' command in Tools menu.")]
        public bool ShowAttachToNUnit { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to ArcSOC' command")]
        [Description("Show 'Attach to ArcSOC' command in Tools menu.")]
        public bool ShowAttachToArcSOC { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to ArcMap' command")]
        [Description("Show 'Attach to ArcMap' command in Tools menu.")]
        public bool ShowAttachToArcMap { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to ArcCatalog' command")]
        [Description("Show 'Attach to ArcCatalog' command in Tools menu.")]
        public bool ShowAttachToArcCatalog { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to DBTool' command")]
        [Description("Show 'Attach to DBTool' command in Tools menu.")]
        public bool ShowAttachToDBTool { get; set; }
    }
}
