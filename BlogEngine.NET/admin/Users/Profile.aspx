<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" Inherits="Admin.Users.ProfilePage" Codebehind="Profile.aspx.cs" %>
<%@ MasterType VirtualPath="~/admin/admin.master" %>
<%@ Import Namespace="BlogEngine.Core" %>
<%@ Register Src="~/admin/htmlEditor.ascx" TagPrefix="Blog" TagName="TextEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphAdmin" Runat="Server">    
	<div class="content-box-outer">
        <asp:PlaceHolder ID="phRightContentBox" runat="server">
		    <div class="content-box-right">
                <ul>
                    <% if (BlogEngine.Core.Security.IsAuthorizedTo(BlogEngine.Core.Rights.EditOtherUsersRoles)) { %>
			        <%--<li><a href="#" class="new"><%=Resources.labels.addNewRole %></a></li>--%>
                    <li><a href="Users.aspx"><%=Resources.labels.users%></a></li>
			        <li><a href="Roles.aspx" class="selected"><%=Resources.labels.roles%></a></li>
                    <% } %>
                    <li class="content-box-selected"><a href="Profile.aspx?id=<%=BlogEngine.Core.Security.CurrentMembershipUser.UserName %>"><%=Resources.labels.profile %></a></li>
                </ul>
		    </div>
        </asp:PlaceHolder>
		<div class="content-box-left">
            <h1 style="border:none;"><%= AvatarImage %> <%=Resources.labels.profile %> : <%=Request.QueryString["id"] %></h1>
            
            <div id="Container"></div>

            <asp:PlaceHolder ID="phRoles" runat="server">
                <h2><%=Resources.labels.roles %></h2>
                <div id="rolelist" style="margin:0 0 20px;"><%=RolesList%></div>
            </asp:PlaceHolder>

            <div id="Container2"></div>
            <div class="action_buttons">
                <input type="submit" id="btnSave" class="btn primary rounded" value="<%=Resources.labels.saveProfile %>" onclick="return SaveProfile()" />
		        <%=Resources.labels.or %> <a href="Users.aspx"><%=Resources.labels.cancel %></a>
            </div>
		</div>
	</div>
    <script type="text/javascript" src="../jquery.tipsy.js"></script>
    <link href="<%=Utils.RelativeWebRoot %>Content/themes/base/minified/jquery-ui.min.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="<%=Utils.RelativeWebRoot %>editors/tiny_mce_3_5_8/tiny_mce.js"></script>
    <script src="<%=Utils.RelativeWebRoot %>Content/ckeditor/ckeditor.js" type="text/javascript"></script>
    <script src="<%=Utils.RelativeWebRoot %>Scripts/jquery-ui.js" type="text/javascript"></script>
    <script type="text/javascript">
        var app = app || {};
        app.biography = '';
        app.initForm = function () {
            $('#txtBirthday').datepicker({ minDate: "-99Y", maxDate: "-18Y" });
            debugger;
            //$('#biography').ckeditor();
            app.biography = CKEDITOR.replace('biography');
        }
        app.initBiography = function () {
            tinyMCE.init({
                // General options
                mode: "exact",
                elements: "biography1",
                encoding: "xml",
                theme: "advanced",
                plugins: "inlinepopups,fullscreen,contextmenu,emotions,table,iespell,advlink,syntaxhighlighter",
                convert_urls: false,

                // Theme options
                theme_advanced_buttons1: "fullscreen,code,|,cut,copy,paste,pastetext,pasteword,|,undo,redo,|,bold,italic,underline,strikethrough,|,blockquote,sub,sup,|,justifyleft,justifycenter,justifyright,|,bullist,numlist,outdent,indent",
                theme_advanced_buttons2: "iespell,link,unlink,removeformat,cleanup,charmap,emotions,|,formatselect,fontselect,fontsizeselect,|,forecolor,backcolor,|,syntaxhighlighter",
                theme_advanced_buttons3: "",
                theme_advanced_toolbar_location: "top",
                theme_advanced_toolbar_align: "left",
                theme_advanced_statusbar_location: "bottom",
                theme_advanced_resizing: true,
                theme_advanced_resize_horizontal: false,
                tab_focus: ":prev,:next",
                gecko_spellcheck: true,

                //Character count        
                theme_advanced_path: false,
                setup: function (ed) {
                    ed.onKeyUp.add(function (ed, e) {

                        var strip = (tinyMCE.activeEditor.getContent()).replace(/(<([^>]+)>)/ig, "");
                        var text = strip.split(' ').length + " Words, " + strip.length + " Characters"
                        tinymce.DOM.setHTML(tinymce.DOM.get(tinyMCE.activeEditor.id + '_path_row'), text);
                    });
                }
            });
        };
    </script>
    <script type="text/javascript">
        function SaveProfile() {
            var vals = new Array();
            var roles = new Array();
            var cnt = 0;

            $.each($('.chkRole:checked'), function (i, v) {
                roles[cnt] = v.id;
                cnt++;
            });

            var displayName = $('#txtDispalayName').val();
            var firstName = $('#txtFirstName').val();
            var middleName = $('#txtMiddleName').val();
            var lastName = $('#txtLastName').val();
            var email = $('#txtEmail').val();
            var birthday = $('#txtBirthday').val();
            var photoURL = $('#txtPhotoURL').val();
            var isPrivate = false;
            if ($('#chkPrivate').is(':checked')) {
                isPrivate = true;
            }
            var mobile = $('#txtMobile').val();
            var phone = $('#txtMainPhone').val();
            var fax = $('#txtFax').val();

            var city = $('#txtCity').val();
            var state = $('#txtState').val();
            var country = $('#txtCountry').val();
            var biography = app.biography.getData(); //tinyMCE.activeEditor.getContent();

            if (displayName.length == 0) {
                $('#txtDispalayNameReq').removeClass('hidden');
                $('#txtDispalayName').focus().select();
                ShowStatus("warning", "Display Name is Required.");
                return false;
            }

            $('#txtDispalayNameReq').addClass('hidden');

            vals[0] = displayName;
            vals[1] = firstName;
            vals[2] = middleName;
            vals[3] = lastName;
            vals[4] = email;
            vals[5] = birthday;
            vals[6] = photoURL;
            vals[7] = isPrivate;
            vals[8] = mobile;
            vals[9] = phone;
            vals[10] = fax;

            vals[11] = city;
            vals[12] = state;
            vals[13] = country;
            debugger;
            vals[14] = biography;

            var dto = { "id": Querystring('id'), "vals": vals, "roles": roles };

            $.ajax({
                url: SiteVars.ApplicationRelativeWebRoot + "api/Profile.asmx/Save",
                data: JSON.stringify(dto),
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                beforeSend: onAjaxBeforeSend,
                success: function (result) {
                    var rt = result.d;
                    if (rt.Success) {
                        ShowStatus("success", rt.Message);
                    }
                    else {
                        ShowStatus("warning", rt.Message);
                    }
                }
            });
            return false;
        }

        LoadProfile();
    </script>
</asp:Content>
