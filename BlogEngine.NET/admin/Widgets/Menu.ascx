<%@ Control Language="C#" AutoEventWireup="true" Inherits="admin.Widgets.Menu" Codebehind="Menu.ascx.cs" %>
<ul>
    <li <%=Current("Blogroll.aspx")%>><a href="Blogroll.aspx"><%=Resources.labels.blogroll %></a></li>
    <li <%=Current("Controls.aspx")%>><a href="Controls.aspx"><%=Resources.labels.commonControls %></a></li>
</ul>