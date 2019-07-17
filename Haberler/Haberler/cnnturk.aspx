<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cnnturk.aspx.cs" Inherits="Haberler.cnnturk" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CnnTürk</title>
    <link href="global.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 209px;
        }
        .auto-style2 {            height: 23px;
        }
        .auto-style3 {
            width: 256px;
        }
        .auto-style7 {
            height: 33px;
        }
        .auto-style8 {
            height: 32px;
        }
        .auto-style9 {
            height: 84px;
        }
        .auto-style10 {
            height: 37px;
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

              

                

                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Son Dakika Haberleri" Width="190px" />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dünya Haberleri" Width="190px" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Türkiye Haberleri" Width="190px" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Kültür-Sanat Haberleri" Width="190px" />
                    <br />
                    <br />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Bilim-Teknoloji Haberleri" Width="190px" />
                    <br />
                    <br />
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Magazin Haberleri" Width="190px" />
                    <br />
                    <br />
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Ekonomi Haberleri" Width="190px" />

              

                

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
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />

              

                

                </div>

                <div class="govdesag">


                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style3" rowspan="4">
                                        <div style="height: 176px">
                                            <asp:Image ID="Image1" runat="server" Height="177px" Width="249px" ImageUrl='<%# Eval("image") %>' />
                                        </div>
                                    </td>
                                    <td class="auto-style10">
                                        <div align="center">
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <div style="height: 76px">
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">
                                        <div>
                                            <asp:Label ID="Label4" runat="server" Text="Link : "></asp:Label>
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("link") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style7">
                                        <div>
                                            <asp:Label ID="Label5" runat="server" Text="Güncellenme Tarihi : "></asp:Label>
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("pubDate") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2" colspan="2">
                                        <div>
                                        </div>
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
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />


                </div>
            <div class="footer" align="center">
           <h1><font face="" size="3" color="maroon">
                <b>Her hakkı saklıdır. @Copyright Gizem Domaç</b> </font></h1>  
            </div>
         </div>
    </form>
</body>
</html>

