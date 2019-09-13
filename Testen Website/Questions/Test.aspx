<%@ Page Title="Test" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Test.aspx.cs" Inherits="Testen_Website.Questions.Test" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <style type="text/css"> 
        .containerBox
        {
            background-color: #f1f1f1;
            box-shadow: 0 2px 4px 0 rgba(0,0,0,0.16),0 2px 10px 0 rgba(0,0,0,0.12) !important;
            margin-top: 3vh;
            padding: 2em 5em;
        }
    </style>
    <form id="test" runat="server">
        <div class="container">
            <div class="col-md-2"></div>
            <div class="col-md-8 containerBox">
                <div>
                    <h2 id="questionsH" class="center-block" runat="server"></h2>
                    <div id="questionsContainer" class="form-group" runat="server">
                    </div>
                </div>
                <div>
                    <div class="col-sm-6 text-center">
                        <asp:Button ID="buttonBack" runat="server" OnClick="ButtonBack" Text="Back" CssClass="btn btn-default"/>
                    </div>
                    <div class="col-sm-6 text-center">
                        <asp:Button ID="buttonNext" runat="server" OnClick="ButtonNext" Text="Next" CssClass="btn btn-primary"/>
                    </div>
                </div>
            </div>
            <div class="col-md-2"></div>
        </div>
    </form>
</asp:Content>