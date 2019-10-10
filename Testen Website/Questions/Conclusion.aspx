<%@ Page Title="Conclusion" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Conclusion.aspx.cs" Inherits="Testen_Website.Questions.Conclusion" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container body-content">
        <form id="conclusion" method="post" runat="server">
            <div class="container">
                <div class="col-md-2"></div>
                <div class="col-md-8 text-center containerBox">
                    <div class="row text-center">
                        <h1 ID="SystemTitle" runat="server"></h1>
                        <div>
                            <asp:Image ID="SystemImage" runat="server" CssClass="img-rounded" style="margin-bottom: 1vh"/>
                        </div>
                    </div>
                    <div class="row text-center">
                        <div class="col-md-2"></div>
                        <div ID="SystemDesc" runat="server" class="col-md-8 text-muted">

                        </div>
                        <div class="col-md-2"></div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </form>
    </div>
</asp:Content>