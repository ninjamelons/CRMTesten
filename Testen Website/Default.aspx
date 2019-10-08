<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Testen_Website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="topBackground blackBack">
        <div class="container">
            <div class="row home_title">
                <div class="col-lg-10 col-md-12">
                    <h1>CRM Testen</h1>
                </div>
            </div>
            <div class="row home_description">
                <div class="col-lg-7 col-lg-offset-3 col-md-10 col-md-offset-2">
                    <p class="subheading">
                        Du kan bruge CRM Testen til at få nogle valgmuligheder til CRM-systemer baseret på jeres egen situation i virksomheden.
                        Når beslutningen om et nyt CRM-system er taget, så begynder udfordringerne med, hvilket system skal vi vælge.
                    </p>
                    <p class="subheading">
                        Besvar spørgsmålene og se hvilket CRM-system, der passer til jeres virksomhed.
                    </p>
                    <div class="row">
                        <div class="col-lg-12">
                            <a href="Questions/Test.aspx" class="btn btn-primary">Start Test</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row home_phrase">
                <div class="col-lg-8">
                    <h2>What a crm system can do</h2>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row home_accordion">
                <div class="col-lg-4 col-md-12">
                    <div class="row">
                        <h3>Functionality 1</h3>
                        <div>
                            <p>functionality 1</p>
                        </div>
                    </div>
                    <div class="row">
                        <h3>Functionality 2</h3>
                        <div>
                            <p>functionality 2</p>
                        </div>
                    </div>
                    <div class="row">
                        <h3>Functionality 2</h3>
                        <div>
                            <p>functionality 2</p>
                        </div>
                    </div>
                    <div class="row">
                        <h3>Functionality 2</h3>
                        <div>
                            <p>functionality 2</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-8 col-md-12">
                    <p>---image of a crm page---</p>
                    <img />
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row home_need">
                <div class="col-lg-4 col-md-5 displayFlex">
                    <h2>Why you need one</h2>
                    <p>paragraph 1</p>
                    <p>paragraph 2</p>
                    <a href="Questions/Test.aspx" class="btn btn-primary">Start Test</a>
                </div>
                <div class="col-lg-8 col-md-7 text-center">
                    <p>---image---</p>
                    <img />
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row home_need">
                <div class="col-lg-7 col-md-6 text-center">
                    <p>---image---</p>
                    <img />
                </div>
                <div class="col-lg-5 col-md-6 displayFlex">
                    <h2>Why you need one 2</h2>
                    <p>paragraph 1</p>
                    <p>paragraph 2</p>
                    <a href="Questions/Test.aspx" class="btn btn-primary">Start Test</a>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row home_example">
                <div class="col-md-4 displayFlex">
                    <h2>example crm</h2>
                    <p>paragraph 1</p>
                    <p>paragraph 2</p>
                </div>
                <div class="col-md-4 displayFlex">
                    <h2>example crm</h2>
                    <p>paragraph 1</p>
                    <p>paragraph 2</p>
                </div>
                <div class="col-md-4 displayFlex">
                    <h2>example crm</h2>
                    <p>paragraph 1</p>
                    <p>paragraph 2</p>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
