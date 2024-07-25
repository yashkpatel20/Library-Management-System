using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Issuereport : System.Web.UI.Page
{
    DS_BRANCH.BRANCH_SELECTDataTable BDT = new DS_BRANCH.BRANCH_SELECTDataTable();
    DS_BRANCHTableAdapters.BRANCH_SELECTTableAdapter BAdapter = new DS_BRANCHTableAdapters.BRANCH_SELECTTableAdapter();
    DS_PUBLICATION.PUBLICATION_SELECTDataTable PubDT = new DS_PUBLICATION.PUBLICATION_SELECTDataTable();
    DS_PUBLICATIONTableAdapters.PUBLICATION_SELECTTableAdapter PubAdapter = new DS_PUBLICATIONTableAdapters.PUBLICATION_SELECTTableAdapter();
    DS_BOOK.BOOK_SELECTDataTable BookDT = new DS_BOOK.BOOK_SELECTDataTable();
    DS_BOOKTableAdapters.BOOK_SELECTTableAdapter BookAdapter = new DS_BOOKTableAdapters.BOOK_SELECTTableAdapter();
    DS_STUDENT.STUDENT_SELECTDataTable SDT = new DS_STUDENT.STUDENT_SELECTDataTable();
    DS_STUDENTTableAdapters.STUDENT_SELECTTableAdapter SAdapter = new DS_STUDENTTableAdapters.STUDENT_SELECTTableAdapter();
    DS_RENT.RENT_SELECTDataTable RDT = new DS_RENT.RENT_SELECTDataTable();
    DS_RENTTableAdapters.RENT_SELECTTableAdapter RAdapter = new DS_RENTTableAdapters.RENT_SELECTTableAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void drpbranch_SelectedIndexChanged(object sender, EventArgs e)
    {
        BookDT = BookAdapter.Select_By_Publication(drpstudent.SelectedItem.Text);
        drpbranch.DataSource = BookDT;
        drpbranch.DataTextField = "Bookname";
        drpbranch.DataValueField = "Bookid";
        drpbranch.DataBind();
        drpbranch.Items.Insert(0, "SELECT");
    }
    protected void Button11_Click(object sender, EventArgs e)
    {

    }
    protected void btnseach_Click(object sender, EventArgs e)
    {
        if (drpstudent.SelectedIndex == 0)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
           
           
        }
        else
        {
            
            BookDT = BookAdapter.Select_By_Publication(drpstudent.SelectedItem.Text);
            GridView1.DataSource = BookDT;
            GridView1.DataBind();
            
            
        }
    }

}