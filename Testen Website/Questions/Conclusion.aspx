<%@ Page Title="Conclusion" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Conclusion.aspx.cs" Inherits="Testen_Website.Questions.Conclusion" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container body-content">
        <form id="conclusion" method="post" runat="server">
            <div class="container">
                <div class="col-md-2"></div>
                <div class="col-md-8 text-center containerBox">                    
                    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
                    <asp:Timer ID="ProgressTimer" runat="server" Interval="3500" OnTick="Timer_Click"></asp:Timer>
                    <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
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
                            <div id="progressDiv" runat="server">
                                <!--<img src="images/ajax-loader-arrows.gif" />-->&nbsp;Vent Venligst...
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ProgressTimer" EventName="Tick" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
                <div class="col-md-2"></div>
            </div>
        </form>
    </div>
</asp:Content>