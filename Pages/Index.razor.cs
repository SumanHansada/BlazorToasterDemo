using System;
using System.Collections.Generic;
using BlazorToasterDemo.Models;
using BlazorToasterDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorToasterDemo.Pages
{
    public partial class Index
    {

        //reference for Toaster Component
        Toaster toaster;

        public IEnumerable<ToastButton> buttons { get; set; }
        public string position { get; set; }
        public bool autoDismiss { get; set; }
        public int autoDismissTime { get; set; }

        protected override void OnInitialized()
        {
            buttons = new List<ToastButton> {
                new ToastButton { Id = 1, Type = "success", ClassName = "success", Label = "Success", Description = "This is a success toast component"},
                new ToastButton { Id = 2, Type = "danger", ClassName = "danger", Label = "Danger", Description = "This is a danger toast component"},
                new ToastButton { Id = 3, Type = "info", ClassName = "info", Label = "Info", Description = "This is a info toast component"},
                new ToastButton { Id = 4, Type = "warning", ClassName = "warning", Label = "Warning", Description = "This is a warning toast component"},
            };

            position = "Select Position";
            autoDismiss = false;
            autoDismissTime = 0;
        }

        protected void AutoDismissToggle()
        {
            autoDismiss = !autoDismiss;
            toaster.ClearToasts();
        }

        protected void SelectPosition(ChangeEventArgs e)
        {
            position = e.Value.ToString();
            toaster.ClearToasts();
        }

        protected void SetAutoDismissTime(ChangeEventArgs e)
        {
            autoDismissTime = Convert.ToInt32(e.Value);
        }

        protected void ShowToast(string type, string description)
        {
            toaster.AddToast(type, description);
        }
    }
}