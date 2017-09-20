<%@ Page Title="" Language="C#" MasterPageFile="~/Private/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="MerCam.Admin.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
            <div class="page-content-wrapper d-flex flex-column justify-content-between px-6 pt-4 pb-0" >
                <div class="page-content">
                    <ul class="nav nav-tabs full-width " id="myTab" role="tablist">
                        <li class="nav-item">
                            <a class="nav-link btn active" id="home-tab" data-toggle="tab"
                                href="#home-tab-pane" role="tab"
                                aria-controls="home-tab-pane" aria-expanded="true">DATOS BASICOS</a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link btn" id="budget-summary-tab" data-toggle="tab"
                                href="#budget-summary-tab-pane"
                                role="tab" aria-controls="budget-summary-tab-pane">USUARIO</a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link btn" id="team-members-tab" data-toggle="tab"
                                href="#team-members-tab-pane"
                                role="tab" aria-controls="team-members-tab-pane">DIRECCIÓN</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link btn" id="team-members1-tab" data-toggle="tab"
                                href="#team-members-tab-pane"
                                role="tab" aria-controls="team-members-tab-pane">TELEFONOS</a>
                        </li>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane fade show active" id="home-tab-pane" role="tabpanel" aria-labelledby="home-tab">
                            <div class="row">
                                <div class="col-md-12"><h3 class="justify-content-center">DATOS PERSONALES DEL USUARIO</h3> </div>
                                <div class="col-md-6">
                                   
                                    <div class="form-group">
                                        <input type="text" class="form-control" id="identificacion" runat="server" placeholder="Identificación" />
                                        <label for="formGroupExampleInput">Indentificacion</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" class="form-control" id="nombres" runat="server" placeholder="Another input" />
                                        <label for="formGroupExampleInput2">Another label</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" class="form-control" id="apellidos" runat="server" placeholder="Example input" />
                                        <label for="formGroupExampleInput">Example label</label>
                                    </div>
                                    <div class="form-group">
                                        <label for="formGroupExampleInput">Selecione</label>
                                        <asp:DropDownList CssClass="form-control" ID="tipoID" runat="server">
                                            <asp:ListItem>Selecione</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    </div>
                                <div class="col-md-6">
                                    
                                    <div class="form-group">
                                        <input type="email" class="form-control" id="correo" runat="server" placeholder="micorreo@server.com" />
                                        <label for="formGroupExampleInput2">Correo</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" class="form-control" id="local" runat="server" placeholder="local" />
                                        <label for="formGroupExampleInput">Ingrese el nombre del local</label>
                                    </div>
                                    <button type="submit" class="btn btn-primary fuse-ripple-ready">MODIFICAR</button>
                                    <a class="btn btn-primary fuse-ripple-ready" href="#budget-summary-tab-pane" runat="server" onserverclick="ActualizarPersona">MODIFICAR</a><br />
                                    <label runat="server" id="msmpers"></label>
                                </div>
                                <div class="col-md-12"> </div>
                            </div>
                        </div>
                        <div class="tab-pane fade" id="budget-summary-tab-pane" role="tabpanel" aria-labelledby="budget-summary-tab">
                            <div class="row">
                                <div class="col-md-6">
                                    <h3 class="justify-content-center">DATOS PERSONALES DEL USUARIO</h3>
                                    <div class="form-group">
                                        <input type="text" class="form-control" id="usuario" runat="server" placeholder="Usuario" />
                                        <label for="formGroupExampleInput">Usuario</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" class="form-control" id="password" runat="server" placeholder="Nueva Contraseña" />
                                        <label for="formGroupExampleInput2">Nueva Contraseña</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" class="form-control" id="confpassword" runat="server" placeholder="Confirmación de la Contraseña" />
                                        <label for="formGroupExampleInput2">Confirme la Contraseña</label>
                                    </div>
                                    <a class="btn btn-primary fuse-ripple-ready" href="#budget-summary-tab-pane" runat="server" onserverclick="Actualizar">Modificar Usuario</a>
                                    <label runat="server" id="msmlabel"></label>
                                </div>
                                <div class="col-md-6">
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade" id="team-members-tab-pane" role="tabpanel" aria-labelledby="team-members-tab">
                            Terciario
                        </div>
                    </div>
                </div>
           </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Pie" runat="server">
</asp:Content>
