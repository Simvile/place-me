<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="place_me.Pages.Clients.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="form-signin w-100 m-auto p-4">
        <div class="mt-5">
            <center>
                <img class="mb-4" src="../../Resources/Images/logo.jpg" alt="" width="92" height="77" />
            </center>
            <h1 class="h3 mb-3 fw-normal">Create your account</h1>

            <div class="form-floating">
                <asp:TextBox class="mt-3 form-control rounded-start rounded-end border p-2" id="floatingInput" runat="server"></asp:TextBox>
                <label for="floatingInput">Full Name</label>
            </div>
            <div class="form-floating">
                <asp:TextBox class="mt-3 form-control rounded-start rounded-end border p-2" id="floatingEmail" runat="server"></asp:TextBox>
                <label for="floatingEmail">Email</label>
            </div>
            <div class="form-floating">
                <asp:TextBox class="mt-3 form-control rounded-start rounded-end border p-2" id="floatingPassword" runat="server"></asp:TextBox>
                <label for="floatingPassword">Password</label>
            </div>
            <div class="form-floating">
                <asp:TextBox class="mt-3 form-control rounded-start rounded-end border p-2" id="floatingStudentNumber" runat="server"></asp:TextBox>
                <label for="floatingReEmail">Student Number</label>
            </div>
            <asp:Button ID="btnregister" runat="server" Text="Create" OnClick="btnregister_Click" class="btn btn-outline-primary w-100 py-2 mb-3 mt-3"  />
            <a class=" mt-5 mb-3 link-underline-light" href="login.aspx">Already have an account ?
            </a>
        </div>
    </main>
</asp:Content>
