using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class SimpleWordTest_comb_t : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // 清空先前保存的選擇
            Session.Remove("PreviousSelections");
        }
        CBF110010_DDL1.SelectedIndexChanged += CBF110010_DDL1_SelectedIndexChanged;
    }
    protected void CBF110010_DDL1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedWord = CBF110010_DDL1.SelectedItem.Text;
        string selectedExplanation = CBF110010_DDL1.SelectedValue;

        // 檢查先前的資料是否存在於會話變數中
        StringBuilder previousSelections = new StringBuilder();

        if (Session["PreviousSelections"] != null)
        {
            previousSelections.Append(Session["PreviousSelections"].ToString());
        }

        // 將先前的資料與新的選擇整合
        string newSelection = $"<a href='https://dictionary.cambridge.org/zht/%E8%A9%9E%E5%85%B8/%E8%8B%B1%E8%AA%9E-%E6%BC%A2%E8%AA%9E-%E7%B9%81%E9%AB%94/{selectedWord}'>{selectedWord}</a> => {selectedExplanation}<br/>";
        previousSelections.Append(newSelection);

        // 更新 Literal 控制項以顯示先前和目前的選擇
        CBF110010_cambridge.Text = previousSelections.ToString();

        // 將新選擇保存至會話變數
        Session["PreviousSelections"] = previousSelections.ToString();
    }
    protected void CBF110010_PreviousButton_Click(object sender, EventArgs e)
    {
       
    }
    protected void CBF110010_NextButton_Click(object sender, EventArgs e)
    {
        
    }
    protected void CBF110010_testBtn_Click(object sender, EventArgs e)
    {
        
    }

}