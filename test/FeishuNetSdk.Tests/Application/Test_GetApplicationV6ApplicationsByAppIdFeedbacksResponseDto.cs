namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取应用反馈列表 响应体
/// <para>接口ID：7072687744306610178</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application-feedback/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-feedback%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6ApplicationsByAppIdFeedbacksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "feedback_list": [
            {
                "feedback_id": "7057888018203574291",
                "app_id": "cli_9b445f5258795107",
                "feedback_time": "2022-01-30 11:30:12",
                "tenant_name": "字节跳动",
                "feedback_type": 1,
                "status": 0,
                "fault_type": [
                    1,
                    2,
                    3
                ],
                "fault_time": "2022-01-30 11:30:12",
                "source": 1,
                "contact": "wang@bytedance.com",
                "update_time": "2022-01-30 11:30:12",
                "description": "反馈描述",
                "user_id": "ou_9565b69967831233761cc2f11b4c089f",
                "operator_id": "ou_9565b69967831233761cc2f11b4c089f",
                "images": [
                    "https://p6-lark-openplatform-image-sign.byteimg.com/*"
                ],
                "feedback_path": "index/page"
            }
        ],
        "has_more": true,
        "page_token": "7064688334618378259"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.GetApplicationV6ApplicationsByAppIdFeedbacksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}