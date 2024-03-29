﻿using ProjectBluejackCake_Group4.Controller;
using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Cake_Page : System.Web.UI.Page
    {
        void loadDataAdmin()
        {
            ViewAllCakeAdmin.DataSource = CakeRepositories.getAllCake();
            ViewAllCakeAdmin.DataBind();
        }

        void loadDataStranger()
        {
            ViewAllCakeStrangers.DataSource = CakeRepositories.getAllCake();
            ViewAllCakeStrangers.DataBind();
        }
        void loadDataCustomer()
        {
            ViewAllCakeCustomer.DataSource = CakeRepositories.getAllCake();
            ViewAllCakeCustomer.DataBind();
        }

        void loadData()
        {
            Member currUser = (Member)Session["userLogin"];

            if (currUser == null)
            {

                btnAddCake.Visible = false;
                btnUpdateCake.Visible = false;
                loadDataStranger();
            }
            else if (currUser.Type == "Admin")
            {
                btnAddCake.Visible = true;
                btnUpdateCake.Visible = true;
                btnViewCart.Visible = false;
                loadDataAdmin();
            }
            else if (currUser.Type == "Customer")
            {
                btnAddCake.Visible = false;
                btnUpdateCake.Visible = false;
                btnViewCart.Visible = true;
                loadDataCustomer();
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCake.aspx");
        }

        protected void btnUpdateCake_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateCake.aspx");
        }

        protected void ViewAllCake_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Member currUser = (Member)Session["userLogin"];

            if (currUser.Type == "Customer")
            {
                lblError.Text = "You're not an admin!";
            }

            else
            {
                String Cake_Name = ViewAllCakeAdmin.Rows[e.RowIndex].Cells[0].Text;

                Cake c = CakeController.get(Cake_Name);
                int row = CakeRepositories.deleteCake(c);
                lblError.Text = "Deletion Success!";
                if (row > 0)
                {
                    loadData();
                }
            }
        }

        protected void Select(object sender, GridViewDeleteEventArgs e)
        {
            String Cake_Name = ViewAllCakeAdmin.Rows[e.RowIndex].Cells[0].Text;
            Cake c = CakeRepositories.getCake(Cake_Name);

            Response.Redirect("BuyCake.aspx?cName=" + Cake_Name);
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        protected void btnAddToCart_Command(object sender, CommandEventArgs e)
        {
            String Cake_Name = e.CommandArgument.ToString();

            Response.Redirect("BuyCake.aspx?cName=" + Cake_Name);
        }

        protected void ViewAllCakeAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String cakeName = ViewAllCakeAdmin.Rows[e.RowIndex].Cells[0].Text;

            Response.Redirect(String.Format("UpdateCake.aspx?cakeName={0}", cakeName));

        }
    }
}