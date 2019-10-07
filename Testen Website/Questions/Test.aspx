<%@ Page Title="Test" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Test.aspx.cs" Inherits="Testen_Website.Questions.Test" %>
<%@ Import Namespace="System.Web.Services" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container body-content">
        <form id="test" runat="server">
            <div class="container">
                <div class="col-md-2"></div>
                <div class="col-md-8 containerBox contPadding">
                    <div>
                        <h2 id="questionsH" class="center-block" runat="server"></h2>
                        <div id="questionsContainer" class="form-group" runat="server">
                        </div>
                    </div>
                    <div>
                        <!--
                        <div class="col-sm-6 text-center">
                            <asp:Button ID="buttonBack" runat="server" OnClick="ButtonBack" Text="Back" CssClass="btn btn-default"/>
                        </div>
                        -->
                        <div class="col-sm-2 text-center">
                            <span id="pageNumber" runat="server"></span>
                        </div>
                        <div class="col-sm-2 col-sm-offset-8 text-center">
                            <asp:Button ID="buttonNext" runat="server" OnClick="ButtonNext" Text="Next" CssClass="btn btn-primary"/>
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </form>
    </div>
</asp:Content>