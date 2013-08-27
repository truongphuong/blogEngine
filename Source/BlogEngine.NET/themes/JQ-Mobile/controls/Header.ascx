<%@ Control Language="C#" AutoEventWireup="true" Inherits="MichaelJBaird.Themes.JQMobile.Controls.Header" Codebehind="Header.ascx.cs" %>
<%@ Import Namespace="BlogEngine.Core" %>
<div data-role="header">
  <h1><%=Server.HtmlEncode(Title) %></h1>
  <a href="<%=Utils.RelativeWebRoot%>default.aspx" data-icon="home" data-iconpos="notext" data-transition="flip"><%= Resources.labels.home %></a>
</div>