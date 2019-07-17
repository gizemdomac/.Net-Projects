<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="haberturk.aspx.cs" Inherits="Haberler.haberturk" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HaberTürk</title>
    <link href="global.css" rel="stylesheet" />
    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 136px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="cerceve">
            <div class="kafa">

            </div>
            <div class="kafamenu">


              

            </div>
            <div class="govde">

                <div class="govdesol" align="center">

                

                    <br />
                    <asp:Button ID="Button1" runat="server" Height="31px" Text="Spor" Width="169px" OnClick="Button1_Click" />
                    ,<br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Height="31px" Text="Magazin" Width="169px" OnClick="Button2_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Height="31px" Text="Ekonomi" Width="169px" OnClick="Button3_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Height="31px" Text="Kadın" Width="169px" OnClick="Button4_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button5" runat="server" Height="31px" Text="Siyaset" Width="169px" OnClick="Button5_Click" style="margin-bottom: 0px" />
                    <br />
                    <br />
                    <asp:Button ID="Button6" runat="server" Height="31px" Text="Tatil" Width="169px" OnClick="Button6_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button7" runat="server" Height="31px" Text="Astroloji" Width="169px" OnClick="Button7_Click" />
                    <br />
                    <br />

                

                </div>

                <div class="govdesag">

                    

                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Italic="True"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <table class="auto-style1">
                                <tr>
                                    <td>
                                        <div align="center">
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("title") %>' Font-Bold="True" Font-Names="Consolas"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <div style="height: 125px">
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">
                                        <div>
                                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Link : "></asp:Label>
                                            &nbsp;
                                            <a href='<%# Eval("link") %>'  target="_blank"><asp:Label ID="Label5" runat="server" Text='<%# Eval("link") %>'></asp:Label></a>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div>
                                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Güncellenme Tarihi : "></asp:Label>
                                            &nbsp;
                                          <asp:Label ID="Label7" runat="server" Text='<%# Eval("pubDate") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div>
                                            &nbsp;</div>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />

                    

                </div>

            </div>
            <div class="footer" align="center">
           <h1><font face="" size="3" color="maroon">
                <b>Her hakkı saklıdır. @Copyright Gizem Domaç</b> </font></h1>  
            </div>
         </div>
    </form>
</body>
</html>

