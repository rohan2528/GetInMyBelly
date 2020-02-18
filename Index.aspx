<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="GetInMyBelly.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get in My Belly!</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="imgcontainer">
                <img src="Food.JPEG" alt="Food" class="food" />
            </div>
        </div>
        <%--<div class="container">
            <label for="uname"><b>Restaurant Name</b></label>
            <asp:TextBox ID="txtRestaurantName" runat="server"></asp:TextBox>

            <label for="psw"><b>Address</b></label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:Button ID="btnRegister" runat="server" CssClass="button" Text="Register" OnClick="btnRegister_Click" />

            

            <label>
                <input type="checkbox" checked="checked" name="remember">
                Remember me
            </label>--%>
        </div>
        <div class="container" style="background-color: #f1f1f1">
            <span>
                <div class="reserve_a_table">

                  <asp:Button ID="btnSoap" runat="server" CssClass="button" Text="SOAP API" OnClick="btnSoap_Click" />
                    <asp:Button ID="btnEstablishments" runat="server" CssClass="button" Text="Restaurant Type" OnClick="btnEstablishments_Click" />

                </div>
                <div class="order_online">
                    <asp:Button ID="btnCollections" runat="server" CssClass="button" Text="Restaurant Collections" OnClick="btnCollections_Click" />

                    <div class="review_us" href="">
                        <asp:Button ID="btnNear" runat="server" CssClass="button" Text="Restaurants Near Me" OnClick="btnNear_Click" />
                    </div>
                </div>
            </span>
        </div>
    </form>
    </body>
</html>
