<%@ Control Language="C#" AutoEventWireup="true" Inherits="Widgets.RecentComments.Edit" Codebehind="edit.ascx.cs" %>

<style type="text/css">
  #body label {display: block; float:left; width:150px}
  #body input {display: block; float:left; }
</style>

<div id="body">

<label for="<%=txtNumberOfPosts.ClientID %>">Number of comments</label>
<asp:TextBox runat="server" ID="txtNumberOfPosts" Width="30" />
<asp:CompareValidator runat="Server" ControlToValidate="txtNumberOfPosts" Type="Integer" Operator="DataTypeCheck" ErrorMessage="Please enter a valid number" Display="Dynamic" />
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtNumberOfPosts" ErrorMessage="Please enter a valid number" Display="dynamic" />

</div>