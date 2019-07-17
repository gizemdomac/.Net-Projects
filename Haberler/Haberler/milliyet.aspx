<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="milliyet.aspx.cs" Inherits="Haberler.milliyet" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MİLLİYET</title>
    
    <link href="global.css" rel="stylesheet" />
     
    <style type="text/css">
        .auto-style4 {
            width: 100%;
            height: 208px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 256px;
        }
        .auto-style7 {
            height: 18px;
        }
        .auto-style8 {
            height: 60px;
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
                    <asp:Button ID="Button2" runat="server" Height="33px" Text="Magazin" Width="185px" OnClick="Button2_Click"  TabIndex="1" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Height="33px" Text="Kitap" Width="185px" OnClick="Button3_Click1" TabIndex="2" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Height="33px" Text="Gündem" Width="185px" OnClick="Button4_Click" TabIndex="3" />
                    <br />
                    <br />
                    <asp:Button ID="Button5" runat="server" Height="33px" Text="Eğtim" Width="185px" OnClick="Button5_Click" TabIndex="4" />
                    <br />
                    <br />
                    <asp:Button ID="Button6" runat="server" Height="33px" Text="Ekonomi" Width="185px" OnClick="Button6_Click" TabIndex="5" />
                    <br />
                    <br />
                    <asp:Button ID="Button7" runat="server" Height="33px" Text="Dünya" Width="185px" OnClick="Button7_Click" TabIndex="6" />
                    <br />
                    <br />
                    <asp:Button ID="Button8" runat="server" Height="33px" Text="Siyaset" Width="185px" OnClick="Button8_Click" TabIndex="7" />
                    <br />
                    <br />
                    <asp:Button ID="Button9" runat="server" Height="33px" Text="Teknoloji" Width="185px" OnClick="Button9_Click" TabIndex="8" />
                    <br />
                    <br />
                    <asp:Button ID="Button10" runat="server" Height="33px" Text="Son Dakika" Width="185px" OnClick="Button10_Click" TabIndex="9" />
                    <br />
                    <br />
                    <asp:Button ID="Button11" runat="server" Height="33px" Text="Milliyet Tatil" Width="185px" OnClick="Button11_Click" TabIndex="10" />
                    <br />
                    <br />
                    <asp:Button ID="Button12" runat="server" Height="33px" Text="Otomobil" Width="185px" OnClick="Button12_Click" TabIndex="11" />
                    <br />
                    <br />
                    <asp:Button ID="Button13" runat="server" Height="33px" Text="Konut - Emlak" Width="185px" OnClick="Button13_Click" TabIndex="12" />
                    <br />
                    <br />
                    <asp:Button ID="Button14" runat="server" Height="33px" Text="PN Aile" Width="185px" OnClick="Button14_Click" TabIndex="13" />
                    <br />
                    <br />
                    <asp:Button ID="Button15" runat="server" Height="33px" Text="PN Sağlık" Width="185px" OnClick="Button15_Click" TabIndex="14" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />

                </div>

                <div class="govdesag">

                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Names="Khmer UI"></asp:Label>
                    <br />
                    <br />
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate >
                            <table class="auto-style4" style="width:900px">
                                <tr>
                                    <td class="auto-style6" rowspan="4">
                                        <div style="height: 169px">
                                            <asp:Image ID="Image1" runat="server" Height="172px" Width="250px" ImageUrl='<%# Eval("resimLink") %>' />
                                        </div>
                                    </td>
                                    <td class="auto-style7">
                                        <div align="center">
                                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial Black" Text='<%# Eval("title") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style8">
                                        <div style="height: 64px">
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">
                                        <div>
                                            <br />
                                            <asp:Label ID="Label4" runat="server" Text="Link : " Font-Bold="True" Font-Italic="True"></asp:Label>
                                            &nbsp;&nbsp;
                                        
                                            <a href='<%# Eval("link") %>'  target="_blank"> <asp:Label ID="Label5" runat="server" Text='<%# Eval("link") %>'></asp:Label>
                                        </a>
                                           </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div>
                                            <br />
                                            <asp:Label ID="Label6" runat="server" Text="Güncellenme Tarihi : " Font-Bold="True" Font-Italic="True"></asp:Label>
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("pubDate") %>'></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5" colspan="2">
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
