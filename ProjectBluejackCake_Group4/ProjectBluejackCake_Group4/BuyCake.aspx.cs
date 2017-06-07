﻿using ProjectBluejackCake_Group4.Handler;
using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class BuyCake : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String cakeName = Request.QueryString["cName"];
            Member m = (Member)Session["userLogin"];

            if (m == null || m.Type == "Administrator" || cakeName == null)
                Response.Redirect("Home.aspx");
            else
            {
                loadCake(cakeName);
                bindPromo();
                txtDiscount.Text = ddlPromotion.SelectedValue;
                txtSubtotal.Text = (Int32.Parse(txtCakePrice.Text) - Int32.Parse(txtDiscount.Text)).ToString();
            }
        }

        void loadCake(String cakeName)
        {
            Cake c = CakeRepositories.getCake(cakeName);

            txtCakeName.Text = c.CakeName;
            txtCakePrice.Text = c.Price.ToString();
        }

        void bindPromo()
        {
            ddlPromotion.DataSource = PromotionHandler.getAll();
            ddlPromotion.DataValueField = "Discount";
            ddlPromotion.DataTextField = "Title";
            ddlPromotion.DataBind();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            String cakeName = txtCakeName.Text;
            int cakePrice = Int32.Parse(txtCakePrice.Text);
            String chocPlat = txtChocPlat.Text;
            String proTitle = ddlPromotion.Text;
            int proDiscount = Int32.Parse(txtDiscount.Text);
            int subTotal = Int32.Parse(txtSubtotal.Text);

            if(chocPlat.Length > 10)
            {
                erMessage.Text = "Chocolate Plate Greeting must not exceed 10 characters.";
            }
            else if(proTitle == null)
            {
                erMessage.Text = "Promotion must be chosen.";
            }
            else
            {
                CartSession newCart = new CartSession(cakeName, cakePrice, chocPlat, proTitle, proDiscount);

                var cart = (List<CartSession>)Session["cartSessionData"];
                cart.Add(newCart);

                erMessage.Text = "Success";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cake_Page.aspx");
        }
    }
}