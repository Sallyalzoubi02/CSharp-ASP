﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addRoom.aspx.cs" Inherits="TASK1.addRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container bg-primary d-flex flex-column align-items-center justify-content-center w-50 mt-5 p-5">
                <label>room id:</label>
                <asp:TextBox ID="roomId" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>room name:</label>
                <asp:TextBox ID="roomName" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>book location:</label>
                <asp:TextBox ID="roomLoc" runat="server"></asp:TextBox>
                <br />
                <br />
                <label> capacity:</label>
                <asp:TextBox ID="capacity" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button CssClass="btn btn-light" ID="add" runat="server" Text="add book" OnClick="add_Click" />
                <asp:Label ID="res" runat="server" Visible="false"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
