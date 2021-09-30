using System;
using System.Collections.Generic;
using BlazorToasterDemo.Models;
using BlazorToasterDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorToasterDemo.Pages
{
    public partial class Index
    {
        public List<Toast> toasts = new();

        protected IEnumerable<ToastButton> buttons = new[] {
            new ToastButton { Id = 1, Type = "success", ClassName = "success", Label = "Success"},
            new ToastButton { Id = 2, Type = "danger", ClassName = "danger", Label = "Info"},
            new ToastButton { Id = 3, Type = "info", ClassName = "info", Label = "Danger"},
            new ToastButton { Id = 4, Type = "warning", ClassName = "warning", Label = "Warning"},
        };

        public string position = "Select Position";
        public bool autoDismiss = false;
        public int autoDismissTime = 0;
        protected string checkIcon = "/assets/check.svg";
        protected string errorIcon = "/assets/error.svg";
        protected string infoIcon = "/assets/info.svg";
        protected string warningIcon = "/assets/warning.svg";

        protected void AutoDismissToggle()
        {
            autoDismiss = !autoDismiss;
            toasts.Clear();
        }

        protected void SelectPosition(ChangeEventArgs e) {
            position = e.Value.ToString();
            toasts.Clear();
        }

        protected void SetAutoDismissTime(ChangeEventArgs e)
        {
            autoDismissTime = Convert.ToInt32(e.Value);
        }

        protected void ShowToast(string type)
        {
            var rand = new Random();
            var id = rand.Next(0, 1000);
            Console.WriteLine("Show Toast is clicked with type - " + type);
            Console.WriteLine("New Toast id is - " + id);

            switch (type)
            {
                case "success":
                    toasts.Add(new Toast
                    {
                        Id = id,
                        Title = "Success",
                        Description = "This is a success toast component",
                        BackgroundColor = "#5cb85c",
                        Icon = checkIcon
                    });
                    break;
                case "danger":
                    toasts.Add(new Toast
                    {
                        Id = id,
                        Title = "Danger",
                        Description = "This is a error toast component",
                        BackgroundColor = "#d9534f",
                        Icon = errorIcon
                    });
                    break;
                case "info":
                    toasts.Add(new Toast
                    {
                        Id = id,
                        Title = "Info",
                        Description = "This is an info toast component",
                        BackgroundColor = "#5bc0de",
                        Icon = infoIcon
                    });
                    break;
                case "warning":
                    toasts.Add(new Toast
                    {
                        Id = id,
                        Title = "Warning",
                        Description = "This is a warning toast component",
                        BackgroundColor = "#f0ad4e",
                        Icon = warningIcon
                    });
                    break;
                default:
                    toasts.Clear();
                    break;
            }
            this.StateHasChanged();
        }
    }
}