﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Book_Sample_Ch03_WebControls_1_Page_Load_1_Error : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = "李小明";  // 網頁一載入，就提供 TextBox 預設值
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "您修改後的名字 -- " + TextBox1.Text;
    }
}