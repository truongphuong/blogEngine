<%@ Control Language="C#" AutoEventWireup="true" Inherits="Admin.Pages.Menu" Codebehind="Menu.ascx.cs" %>
<ul>
    <li <%=Current("EditPage.aspx")%>><a href="EditPage.aspx" class="new"><%=Resources.labels.addNewPage %></a></li>
    <li <%=Current("Pages.aspx")%>><a href="Pages.aspx"><%=Resources.labels.pages %></a></li>
</ul>