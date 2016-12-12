<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Payroll_Management_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PMS</title>
    <link type="text/css" href="~/Css/Login.css" rel="stylesheet" />
</head>
<body>
    <div class="background">
        <div class="dialog">
            <div class="login">
                <div class="loginCheck">                    
                </div>
                <div class="loginForm"> 
                    <form id="loginDetails" runat="server">
                        <div class="loginRow">
                            <svg class="loginUser name svg-icon" viewBox="0 0 20 20">
                                <path d="M0,20 a10,8 0 0,1 20,0z M10,0 a4,4 0 0,1 0,8 a4,4 0 0,1 0,-8"></path>                                
                            </svg>
                            <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" MaxLength="20" ToolTip="Enter Username"></asp:TextBox> 
                        </div>
                        <div class="loginRow">
                            <svg class="loginUser pass svg-icon" viewBox="0 0 20 20">
                                <path d="M0,20 20,20 20,8 0,8z M10,13 10,16z M4,8 a6,8 0 0,1 12,0"></path>                                
                            </svg> 
                            <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" MaxLength="20" TextMode="Password" ToolTip="Enter Password"></asp:TextBox>
                        </div>
                        <h1 id="lblError" runat="server"></h1>
                        <button id="btnSubmit" type="button" runat="server">Sign in</button>
                        <%--<asp:Button ID="btnSubmit" runat="server" Text="Sign in" OnClick="btnSubmit_Click" />--%>
                        <p class="signUp">
                            Dont have an account?
                            <a>Sign up</a>
                        </p>
                    </form>                    
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="../Scripts/jquery-3.1.1.min.js"></script>
    <script type="text/javascript" src="../Scripts/Login.js"></script>
</body>
</html>