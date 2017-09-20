<%@ Page Title="" Language="C#" MasterPageFile="~/Private/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MerCam.Admin.Setting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Encabezado" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <div class="page-header bg-success text-auto d-flex flex-column justify-content-between px-6 pt-4 pb-0" id="msmbienvenida">
        <div class="row no-gutters align-items-start justify-content-center flex-nowrap">
            <div>
                <p class="h2"><asp:label runat="server" id="nombre"></asp:label>!</p>
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6 col-xl-6">
                <div class="page-content">

                    <!-- HEADER -->
                    <div class="header py-6 text-center">
                        <span class="h3 ">COOPMERCASAN</span>
                    </div>
                    <!-- / HEADER -->

                    <div class="page-content-card">
                        <!-- / CONTENT TOOLBAR -->

                        <div class="p-6">
                            <!-- DEMO CONTENT -->
                            <div class="demo-content">

                                <img src="../Estilo/Admin/assets/images/etc/early-sunrise.jpg" class="w-100 mb-4" alt="sunrise" />

                                <h4 class="secondary-text">Hagamos Mercados Justos</h4>

                                <p>
                                    Cooperativa Multiactiva Mercado Campesino Santo Domingo San Marín
                                </p>

                            </div>
                            <!-- / DEMO CONTENT -->
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-md-6 col-xl-6">
                Ingrese su identificacion:<asp:TextBox runat="server" ID="id"></asp:TextBox>
                <asp:Button runat="server" Text="Consultar" OnClick="Unnamed2_Click" />
                <asp:Label runat="server" Text="Label" ID="error"></asp:Label><br />
                <br />
                Login Simulacion
    <asp:TextBox runat="server" ID="usuario"></asp:TextBox>
                <asp:TextBox runat="server" ID="paswwor"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

                <div class="page-content">

                    <!-- HEADER -->
                    <div class="header py-6 text-center">
                        <span class="h3 "> </span>
                    </div>

                    <div class="header py-6 text-center">
                        <span class="h3 ">Productos alimenticios cultivados y procesados por familias campesinas con amor y arte-sano</span>
                    </div>
                    <div class="header py-6 text-center">
                        <span class="h3 "> </span>
                    </div>
                    <div class="header py-6 text-center">
                        <span class="h4 ">Inpulsa las propuestas de Produción Orgánicas Sostenibles genera Sguridad Alimentaria hacia una vida digna</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Pie" runat="server">
</asp:Content>
