using System;
using System.Collections.Generic;
using BlazorToasterDemo.Models;
using BlazorToasterDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorToasterDemo.Pages
{
    public partial class Index
    {
        protected IEnumerable<ToastButton> buttons = new[] {
            new ToastButton { Id = 1, Type = "success", ClassName = "success", Label = "Success", Description = "This is a success toast component"},
            new ToastButton { Id = 2, Type = "danger", ClassName = "danger", Label = "Danger", Description = "This is a danger toast component"},
            new ToastButton { Id = 3, Type = "info", ClassName = "info", Label = "Info", Description = "This is a info toast component"},
            new ToastButton { Id = 4, Type = "warning", ClassName = "warning", Label = "Warning", Description = "This is a warning toast component"},
        };

        public string position = "Select Position";
        public bool autoDismiss = false;
        public int autoDismissTime = 0;

        //reference for Toaster Component
        Toaster toaster;

        protected void AutoDismissToggle()
        {
            autoDismiss = !autoDismiss;
            toaster.ClearToasts();
        }

        protected void SelectPosition(ChangeEventArgs e) {
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