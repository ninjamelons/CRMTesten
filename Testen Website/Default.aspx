<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Testen_Website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
            <div class="row containerBox contPadding contMargin">
                <div class="row home_title">
                    <div class="col-lg-10 col-md-12">
                        <h1>Velkommen til CRM Testen</h1>
                    </div>
                </div>
                <div class="col-lg-7 col-lg-offset-3 col-md-10 col-md-offset-2">
                    <p>
                        Vi ved det godt. Der findes et hav af CRM systemer.
                    </p>
                    <p>
                        Ved at besvare 12 simple spørgsmål, får du forslag til hvilke CRM systemer, der er relevante for din virksomhed eller organisation. Jo mere nøjagtigt du besvarer spørgsmålene, jo bedre kan vi vurdere jeres situation.
                    </p>
                    <p>
                        Det er op til dig, hvordan du vil bruge CRM Testen. Du kan bruge den til at få relevante muligheder at vælge mellem. Men du kan også bruge den til at vurdere, om I overhovedet har behov for et CRM system i jeres organisation.
                    </p>
                    <p>
                        Besvar spørgsmålene og se hvilket CRM-system, der passer til jer. Det tager kun få minutter, og du får svar med det samme.
                    </p>
                    <div class="row">
                        <div class="col-lg-12">
                            <a href="Questions/Test.aspx" class="btn btn-primary">Start CRM Testen</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
