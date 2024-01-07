<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="webproje.WebForm3" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Turnuva Oluştur</title>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.min.css" />
    <!-- Custom CSS -->
    <style>
        body {
            background-color: #f8f9fa;
            padding-top: 70px; /* Adjust padding to prevent content from being hidden under the fixed navbar */
        }

        .container {
            margin-top: 100px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .btn {
            background-color: #007bff;
            color: #ffffff;
        }
    </style>
</head>
<body>
    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top">
        <a class="navbar-brand" href="#">Tournament</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item">
                    <a class="nav-link" href="WebForm3.aspx">Homepage</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="WebForm2.aspx">Register</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="WebForm2.aspx">Login</a>
                </li>
            </ul>
        </div>
    </nav>

    <form id="form1" runat="server">
        <div class="container">
            <h2>Turnuva Oluştur</h2>
            <asp:Label ID="lblPlayerCount" runat="server" Text="Kaç kişi katılacak?"></asp:Label>
            <asp:TextBox ID="txtPlayerCount" runat="server"></asp:TextBox>
            <asp:Button ID="btnStartTournament" runat="server" Text="Turnuvayı Başlat" OnClick="btnStartTournament_Click" />
        </div>
    </form>

    <!-- Bootstrap JS and Popper.js (required for Bootstrap components) -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
