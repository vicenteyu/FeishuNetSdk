namespace FeishuNetSdk.Tests.Admin;

/// <summary>
/// 测试 获取部门维度的用户活跃和功能使用数据 响应体
/// <para>接口ID：6954303251601309723</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/data-report-management/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fadmin_dept_stat%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAdminV1AdminDeptStatsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "3",
        "items": [
            {
                "date": "2020-02-15",
                "department_id": "od-382e2793cfc9471f892e8a672987654c",
                "department_name": "subtestkkk",
                "department_path": "testkkk/subtestkkk",
                "total_user_num": 2,
                "active_user_num": 0,
                "active_user_rate": "1.00",
                "suite_dau": 0,
                "suite_active_rate": "0.00",
                "new_user_num": 0,
                "new_active_num": 0,
                "resign_user_num": 0,
                "im_dau": 0,
                "send_messenger_user_num": 0,
                "send_messenger_num": 0,
                "avg_send_messenger_num": "0.00",
                "docs_dau": 0,
                "create_docs_user_num": 0,
                "create_docs_num": 0,
                "avg_create_docs_num": "0.00",
                "cal_dau": 0,
                "create_cal_user_num": 0,
                "create_cal_num": 0,
                "avg_create_cal_num": "0.00",
                "vc_dau": 0,
                "vc_duration": 0,
                "avg_vc_duration": "0.00",
                "avg_duration": "0.00",
                "task_dau": 0,
                "create_task_user_num": 0,
                "create_task_num": 0,
                "avg_create_task_num": "0.00",
                "email_send_count": "2",
                "email_receive_count": "3",
                "email_send_ext_count": "4",
                "email_receive_ext_count": "5",
                "email_send_in_count": "6",
                "email_receive_in_count": "7",
                "search_active_dau": "7",
                "total_search_count": "7",
                "quick_search_count": "7",
                "tab_search_count": "7",
                "product_version": "全部产品版本"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Admin.GetAdminV1AdminDeptStatsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}