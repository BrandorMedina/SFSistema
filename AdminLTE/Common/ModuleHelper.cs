using AdminLTE.Models;
using System;

namespace AdminLTE.Common
{
    /// <summary>
    /// This is where you customize the navigation sidebar
    /// </summary>
    public static class ModuleHelper
    {
        public enum Module
        {
            Inicio,
            About,
            Contact,
            Error,
            Login,
            Register,
            SuperAdmin,
            Role,
            UserLogs,
            Documentos
        }

        public static SidebarMenu AddHeader(string name)
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Header,
                Name = name,
            };
        }

        public static SidebarMenu AddTree(string name, string iconClassName = "fa fa-link")
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Tree,
                IsActive = false,
                Name = name,
                IconClassName = iconClassName,
                URLPath = "#",
            };
        }

        public static SidebarMenu AddModule(Module module, Tuple<int, int, int> counter = null)
        {
            if (counter == null)
                counter = Tuple.Create(0, 0, 0);

            switch (module)
            {
                case Module.Inicio:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Inicio",
                        IconClassName = "fa fa-home",
                        URLPath = "/",
                        LinkCounter = counter,
                    };
                case Module.Documentos:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Documentos",
                        IconClassName = "fa fa-file",
                        URLPath = "/Doc/Index",
                        LinkCounter = counter,
                    };
                case Module.Login:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Login",
                        IconClassName = "fa fa-sign-in",
                        URLPath = "/Account/Login",
                        LinkCounter = counter,
                    };
                case Module.Register:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Registro",
                        IconClassName = "fa fa-user-plus",
                        URLPath = "/Account/Register",
                        LinkCounter = counter,
                    };
                case Module.About:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "About",
                        IconClassName = "fa fa-users",
                        URLPath = "/Home/About",
                        LinkCounter = counter,
                    };
                case Module.Contact:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Contact",
                        IconClassName = "fa fa-phone",
                        URLPath = "/Home/Contact",
                        LinkCounter = counter,
                    };
                case Module.Error:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Error",
                        IconClassName = "fa fa-exclamation-triangle",
                        URLPath = "/Home/Error",
                        LinkCounter = counter,
                    };
                case Module.SuperAdmin:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Usuario",
                        IconClassName = "fa fa-link",
                        URLPath = "/SuperAdmin",
                        LinkCounter = counter,
                    };
                case Module.Role:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Roles",
                        IconClassName = "fa fa-link",
                        URLPath = "/Role",
                        LinkCounter = counter,
                    };
                case Module.UserLogs:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "UserLogs",
                        IconClassName = "fa fa-link",
                        URLPath = "/UserLogs",
                        LinkCounter = counter,
                    };

                default:
                    break;
            }

            return null;
        }
    }
}
