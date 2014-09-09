// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace MyClientForMSExchange.Controllers
{
    public partial class HomeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string LogOut = "LogOut";
            public readonly string SentItems = "SentItems";
            public readonly string DeletedItems = "DeletedItems";
            public readonly string Drafts = "Drafts";
            public readonly string NewEmail = "NewEmail";
            public readonly string DeleteEmail = "DeleteEmail";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string LogOut = "LogOut";
            public const string SentItems = "SentItems";
            public const string DeletedItems = "DeletedItems";
            public const string Drafts = "Drafts";
            public const string NewEmail = "NewEmail";
            public const string DeleteEmail = "DeleteEmail";
        }


        static readonly ActionParamsClass_NewEmail s_params_NewEmail = new ActionParamsClass_NewEmail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_NewEmail NewEmailParams { get { return s_params_NewEmail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_NewEmail
        {
            public readonly string emailModel = "emailModel";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string About = "About";
                public readonly string Contact = "Contact";
                public readonly string DeletedItems = "DeletedItems";
                public readonly string DeleteEmail = "DeleteEmail";
                public readonly string Drafts = "Drafts";
                public readonly string Index = "Index";
                public readonly string NewEmail = "NewEmail";
                public readonly string SentItems = "SentItems";
            }
            public readonly string About = "~/Views/Home/About.cshtml";
            public readonly string Contact = "~/Views/Home/Contact.cshtml";
            public readonly string DeletedItems = "~/Views/Home/DeletedItems.cshtml";
            public readonly string DeleteEmail = "~/Views/Home/DeleteEmail.cshtml";
            public readonly string Drafts = "~/Views/Home/Drafts.cshtml";
            public readonly string Index = "~/Views/Home/Index.cshtml";
            public readonly string NewEmail = "~/Views/Home/NewEmail.cshtml";
            public readonly string SentItems = "~/Views/Home/SentItems.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : MyClientForMSExchange.Controllers.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void LogOutOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult LogOut()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LogOut);
            LogOutOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SentItemsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult SentItems()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SentItems);
            SentItemsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DeletedItemsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeletedItems()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeletedItems);
            DeletedItemsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DraftsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Drafts()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Drafts);
            DraftsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NewEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult NewEmail()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.NewEmail);
            NewEmailOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NewEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, MyClientForMSExchange.Models.Entities.Email emailModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult NewEmail(MyClientForMSExchange.Models.Entities.Email emailModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.NewEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailModel", emailModel);
            NewEmailOverride(callInfo, emailModel);
            return callInfo;
        }

        [NonAction]
        partial void DeleteEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteEmail()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteEmail);
            DeleteEmailOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009