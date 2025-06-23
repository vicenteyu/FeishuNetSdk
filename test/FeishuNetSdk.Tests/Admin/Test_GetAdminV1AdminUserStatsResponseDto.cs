namespace FeishuNetSdk.Tests.Admin;

/// <summary>
/// 测试 获取用户维度的用户活跃和功能使用数据 响应体
/// <para>接口ID：6954303251601276955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/data-report-management/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fadmin_user_stat%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAdminV1AdminUserStatsResponseDto : TestBase
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
                "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "user_name": "Zhang San",
                "department_name": "testcqlbfaaasdasdasd",
                "department_path": "testkkk/testcqlbfaaasdasdasd",
                "create_time": "2020-09-04 11:17:55",
                "user_active_flag": 1,
                "register_time": "2020-09-04 11:18:32",
                "suite_active_flag": 1,
                "last_active_time": "2020-12-21 22:21:28",
                "im_active_flag": 1,
                "send_messenger_num": 0,
                "docs_active_flag": 1,
                "create_docs_num": 1,
                "cal_active_flag": 1,
                "create_cal_num": 0,
                "vc_active_flag": 1,
                "vc_duration": 0,
                "active_os": "'ios 14.2,-','ios 14.2,feishu 3.40.0-alpha'",
                "create_task_num": 0,
                "vc_num": 0,
                "app_package_type": "Feishu，Lark",
                "os_name": "iOS,Andorid,Windows",
                "email_send_count": "2",
                "email_receive_count": "3",
                "email_send_ext_count": "4",
                "email_receive_ext_count": "5",
                "email_send_in_count": "6",
                "email_receive_in_count": "7",
                "search_active_flag": 1,
                "total_search_count": "7",
                "quick_search_count": "7",
                "tab_search_count": "7"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Admin.GetAdminV1AdminUserStatsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}