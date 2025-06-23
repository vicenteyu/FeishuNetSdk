namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取指定人员审批任务列表 响应体
/// <para>接口ID：7426325309484040193</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/approver-task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapprover%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2ApproversResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "1",
        "has_more": true,
        "approver_list": [
            {
                "approver_id": "7410781046418966060",
                "process_id": "7410781046418966060",
                "approver_status": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2ApproversResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}