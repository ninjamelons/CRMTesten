<%@ Page Title="Test" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Test.aspx.cs" Inherits="Testen_Website.Questions.Test" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container body-content">
        <form id="test" runat="server">
            <div class="container">
                <div class="col-md-2"></div>
                <div class="col-md-8 containerBox contPadding">
                    <div>
                        <h2 id="questionsH" class="center-block" runat="server"></h2>
                        <div id="questionsContainer" class="form-group" runat="server">
                        <asp:Repeater ID="QuestionsList" runat="server" ItemType="Testen_Website.Models.QuestionRep">
                            <ItemTemplate>
                                <div id="question<%# Item.ID %>" class="row">
                                    <h4><%# Item.Value %></h4>
                                    <asp:Repeater DataSource="<%#Item.Answers%>" runat="server" ItemType="Testen_Website.Models.Answer">
                                        <ItemTemplate>
                                            <%// Parent DataItems light up red but it works, it is an intellisense issue %>
                                            <div class="inputPadding">
                                                <label>
                                                    <input name="quest<%# DataBinder.Eval(((RepeaterItem)Container.Parent.Parent).DataItem, "ID") %>"
                                                           type="<%# DataBinder.Eval(((RepeaterItem)Container.Parent.Parent).DataItem, "InputType") %>"
                                                           value="<%#Item.Value %>"/>
                                                    <%#Item.Label %>
                                                </label>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </ItemTemplate>
                            <SeparatorTemplate>
                                <hr class="testHr">
                            </SeparatorTemplate>
                        </asp:Repeater>
                        </div>
                    </div>
                    <br />
                    <div>
                        <div class="col-sm-2 col-sm-offset-8 text-center">
                            <asp:Button ID="buttonNext" runat="server" OnClick="ButtonNext" Text="Næste side" CssClass="btn btn-primary"/>
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </form>
    </div>
</asp:Content>