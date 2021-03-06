﻿<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ShopApp.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail"   runat="server" ItemType="ShopApp.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %> </h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="../Images/<%#:Item.ImagePath %>"
                                        width="300" height="250" style="border: solid" />
                      
                    </td>
                    <td></td>
                    <td style="vertical-align: top; text-align:left; ">
                        <b>Description: </b> <br /> <%#:Item.Description %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#:String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Product Number:</b>&nbsp;<%#:Item.ProductID %></span>
                        <br />

                    </td>
                </tr>
            </table>
        </ItemTemplate>


    </asp:FormView>


</asp:Content>
